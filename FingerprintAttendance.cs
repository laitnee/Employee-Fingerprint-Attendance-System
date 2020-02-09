using FingerprintAttendanceSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerprintAttendanceSystem
{
    public partial class FingerprintAttendance : Form, DPFP.Capture.EventHandler
    {
        public FingerprintAttendance()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime _currentDate = DateTime.Now;
            timeLbl.Text = "" + _currentDate.Hour.ToString() + " : " +  _currentDate.Minute.ToString();
            dtLbl.Text = _currentDate.ToLongDateString();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            LogStaff logStaff = new LogStaff();
            logStaff.stopAttendance();
            this.Close();
        }

        private void FingerprintAttendance_Load(object sender, EventArgs e)
        {
            initFingerprint();
        }


        //################ FINGERPRINT READER CONTROLS ###############################
        #region Fingerprint Region:

        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        private DPFP.Capture.Capture Capturer;

        private void initFingerprint()
        {
            Init();
        }
        protected virtual void Init()
        {
            fpStatusLbl.Text = "Initializing biometric scanner";
            try
            {
                Capturer = new DPFP.Capture.Capture();
                Verificator = new DPFP.Verification.Verification();// Create a capture operation.
                if (null != Capturer)
                {
                    Capturer.EventHandler = this;
                    fpStatusLbl.Text = "biometric initiated";
                    Capturer.StartCapture();
                    rptLbl.Text = "Scan your fingerprint.";
                }
                else
                {
                    fpStatusLbl.Text = "Error!";
                }
            }
            catch
            {
                MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        protected void Start()
        {
            if (null != Capturer)
            {
                Capturer.StartCapture();
                rptLbl.Text = "Scan your fingerprint.";
            }
            else
            {
                fpStatusLbl.Text = "Error!";
            }
        }
        protected void Stop()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    fpStatusLbl.Text = "Can't terminate capture!";
                }
            }
        }
        protected void stopScanner()
        {
            Stop();
        }
        protected virtual void Process(DPFP.Sample Sample)
        {

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            if (features != null)
            {
                
                List<Staff> staffs;
                // Compare the feature set with our template
                using (ModelContext db = new ModelContext())
                {
                    staffs = db.Staffs.ToList();
                }

                Template = new DPFP.Template();
                foreach (var staff in staffs)
                {
                    if (staff.Fingerprint != null)
                    {
                        Template.DeSerialize(staff.Fingerprint);
                        DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                        Verificator.Verify(features, Template, ref result);
                        if (result.Verified) {
                            verPicBox.Invoke(new Action(() => {
                                verPicBox.ImageLocation = staff.ImageUrl;
                                verPicBox.Visible = true;
                            }));
                            rptLbl.Invoke(new Action(() => rptLbl.Text = $"{staff.Lastname} {staff.Firstname} VERIFIED."));
                            LogStaff logStaff = new LogStaff();
                             switch (logStaff.LogAttendance(staff))
                             {
                                case 0:
                                    rptLbl.Invoke(new Action(() => rptLbl.Text = $"{staff.Lastname} {staff.Firstname} already logged."));
                                    break;
                                case 1:
                                    rptLbl.Invoke(new Action(() => rptLbl.Text = $"{staff.Lastname} {staff.Firstname} Goodbye!."));
                                    break;
                                case 2:
                                    rptLbl.Invoke(new Action(() => rptLbl.Text = $"{staff.Lastname} {staff.Firstname} Welcome!."));
                                    break;
                                default:
                                    rptLbl.Invoke(new Action(() => rptLbl.Text = $"error"));
                                    break;
                             };
                            break;
                    }
                    else
                        rptLbl.Invoke(new Action(() => rptLbl.Text = "The fingerprint was NOT VERIFIED."));
                    }

                }

            }
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();  // Create a feature extractor
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);            // TODO: return features as a result?
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }


        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            fpStatusLbl.Invoke(new Action(() =>  fpStatusLbl.Text = "biometric scanner connected."));
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            fpStatusLbl.Invoke(new Action(() => fpStatusLbl.Text = "biometric scanner disconnected."));
        }
        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            verPicBox.Invoke(new Action(() => {
                verPicBox.Visible = false;
                verPicBox.ImageLocation = null;
            }));
            rptLbl.Invoke(new Action(() => rptLbl.Text = "captured"));
            Process(Sample);

        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            System.Threading.Thread.Sleep(1000);
            rptLbl.Invoke(new Action(() => rptLbl.Text = "Scan your finger."));
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            rptLbl.Invoke(new Action(() =>  rptLbl.Text = "Scanning..."));
        }
        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                rptLbl.Invoke(new Action(() => rptLbl.Text = "The quality of the fingerprint sample is good."));
            else
                rptLbl.Invoke(new Action(() => rptLbl.Text = "The quality of the fingerprint sample is poor."));
        }
        #endregion

        private void FingerprintAttendance_FormClosed(object sender, FormClosedEventArgs e)
        {
            stopScanner();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
