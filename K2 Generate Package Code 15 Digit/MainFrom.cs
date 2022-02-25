using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K2_Generate_Package_Code_15_Digit
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
            services = new Services.MainServices();
            PkgTypeGlobal = new List<DAL.PackageType>();
            PkgHGlobal = new List<DAL.PackageHeight>();
            PkgSpGlobal = new List<DAL.PackageSpecialCode>();
            IntDecimalGlobal = new List<DAL.IntDecimal>();
            ControlGlobal = new List<DAL.Control>();
            LeadBallPitchGlobal = new List<DAL.LeadBallPitch>();
            PinBallCountGlobal = new List<DAL.PinBallCount>();
            FrameFlowTypeGlobal = new List<DAL.FrameFlowType>();
            MoldThicknessGlobal = new List<DAL.MoldThickness>();
            AnotherDecimalGlobal = new List<DAL.AnotherDecimal>();
            PackageThicknessAfterMoldGlobal = new List<DAL.PackageThicknessAfterMold>();
            BallHeightGlobal = new List<DAL.BallHeight>();
            m2PkgthicknessesGlobal = new List<DAL.M2pkgthickness>();
            m2PkgsizesGlobal = new List<DAL.M2pkgsize>();
            M2LeadframeTypesGlobal = new List<DAL.M2LeadframeType>();
            M2DAGlobal = new List<DAL.M2DA>();
            M2SpecialMoldFeatureGlobal = new List<DAL.M2SpecialMoldFeature>();
            M2DepopulatePinGlobal = new List<DAL.M2DepopulatePin>();
            M2PlatingTypePublic = new List<DAL.M2PlatingType>();
            M2DAMandFillareaGlobal = new List<DAL.M2DAMandFillarea>();
        }
        private Services.MainServices services;
        public List<DAL.PackageType> PkgTypeGlobal;
        public List<DAL.PackageHeight> PkgHGlobal;
        public List<DAL.PackageSpecialCode> PkgSpGlobal;
        public List<DAL.IntDecimal> IntDecimalGlobal;
        public List<DAL.Control> ControlGlobal;
        public List<DAL.LeadBallPitch> LeadBallPitchGlobal;
        public List<DAL.PinBallCount> PinBallCountGlobal;
        public List<DAL.FrameFlowType> FrameFlowTypeGlobal;
        public List<DAL.MoldThickness> MoldThicknessGlobal;
        public List<DAL.AnotherDecimal> AnotherDecimalGlobal;
        public List<DAL.PackageThicknessAfterMold> PackageThicknessAfterMoldGlobal;
        public List<DAL.BallHeight> BallHeightGlobal;
        public List<DAL.M2pkgthickness> m2PkgthicknessesGlobal;
        public List<DAL.M2pkgsize> m2PkgsizesGlobal;
        public List<DAL.M2LeadframeType> M2LeadframeTypesGlobal;
        public List<DAL.M2DA> M2DAGlobal;
        public List<DAL.M2WB> M2WBGlobal;
        public List<DAL.M2SpecialMoldFeature> M2SpecialMoldFeatureGlobal;
        public List<DAL.M2DepopulatePin> M2DepopulatePinGlobal;
        public List<DAL.M2PlatingType> M2PlatingTypePublic;
        public List<DAL.C5PackageCode> C5PackageCodeGlobal;
        public List<DAL.M2DAMandFillarea> M2DAMandFillareaGlobal;
        public Color oc1;
        public Color oc2;
        public Color oc3;
        public Color oc4;
        public Color oc5;
        public Color oc6;
        public Color oc7;
        public Color oc8;
        public Color oc9;
        public Color oc10;
        public Color oc11;
        public Color oc12;
        public Color oc13;
        public Color oc14;
        public Color oc15;


        private void MainFrom_Load(object sender, EventArgs e)
        {
            oc1 = tableLayoutPanelNo1.BackColor;
             oc2 = tableLayoutPanelNo2.BackColor;
             oc3 = tableLayoutPanelNo3.BackColor;
             oc4 = tableLayoutPanelNo4.BackColor;
             oc5 = tableLayoutPanelNo5.BackColor;
             oc6 = tableLayoutPanelNo6.BackColor;
             oc7 = tableLayoutPanelNo7.BackColor;
             oc8 = tableLayoutPanelNo8.BackColor;
             oc9 = tableLayoutPanelNo9.BackColor;
             oc10 = tableLayoutPanelNo10.BackColor;
             oc11 = tableLayoutPanelNo11.BackColor;
             oc12 = tableLayoutPanelNo12.BackColor;
             oc13 = tableLayoutPanelNo13.BackColor;
             oc14 = tableLayoutPanelNo14.BackColor;
             oc15 = tableLayoutPanelNo15.BackColor;


            comboBoxPKGG.SelectedItem = "Normal";
            var pkgtype = services.GetPkgType();
            var pkgH = services.GetPkgH();
            var pkSp = services.GetPkgSpCode();
            var idcm = services.GetIntDecimal();
            var con = services.GetControl();
            var lbp = services.GetLeadBallPitch();
            var pbc = services.GetPinBallCount();
            var fft = services.GetFrameFlowType();
            var mmt = services.GetMoldThickness();
            var bhh = services.GetBallHeight();
            var tam = services.GetpkgThicknessAfterMold();
            var adc = services.AnotherDecimal();
            var pTN = services.GetPkgThickness();
            var siz = services.GetpkgSize();
            var lft = services.GetLeadFrameType();
            var da = services.GetDA();
            var wb = services.GetWB();
            var smf = services.GetSpecialMoldFeature();
            var dpp = services.GetDepopulatePin();
            var platT = services.GetPlatingType();
            var DaF = services.GetDamAndFieldArea();

            var c5Pack = services.Get5pack();
            if (pkgtype.ObjResult.Count > 0)
            {
                PkgTypeGlobal = pkgtype.ObjResult;

            }
            if (pkgH.ObjResult.Count > 0)
            {
                PkgHGlobal = pkgH.ObjResult;
            }
            if (pkSp.ObjResult.Count > 0)
            {
                PkgSpGlobal = pkSp.ObjResult;

            }
            if (idcm.ObjResult.Count > 0)
            {
                IntDecimalGlobal = idcm.ObjResult;

            }
            if (con.ObjResult.Count > 0)
            {
                ControlGlobal = con.ObjResult;

            }
            if (lbp.ObjResult.Count > 0)
            {
                LeadBallPitchGlobal = lbp.ObjResult;

            }
            if (pbc.ObjResult.Count > 0)
            {
                PinBallCountGlobal = pbc.ObjResult;

            }
            if (fft.ObjResult.Count > 0)
            {
                FrameFlowTypeGlobal = fft.ObjResult;

            }
            if (mmt.ObjResult.Count > 0)
            {
                MoldThicknessGlobal = mmt.ObjResult;

            }
            if (adc.ObjResult.Count > 0)
            {
                AnotherDecimalGlobal = adc.ObjResult;
            }
            if (tam.ObjResult.Count > 0)
            {
                PackageThicknessAfterMoldGlobal = tam.ObjResult;
            }
            if (bhh.ObjResult.Count > 0)
            {
                BallHeightGlobal = bhh.ObjResult;
            }
            if (pTN.ObjResult.Count > 0)
            {
                m2PkgthicknessesGlobal = pTN.ObjResult;
            }
            if (siz.ObjResult.Count > 0)
            {
                m2PkgsizesGlobal = siz.ObjResult;
            }
            if (lft.ObjResult.Count > 0)
            {
                M2LeadframeTypesGlobal = lft.ObjResult;
            }
            if(da.ObjResult.Count > 0)
            {
                M2DAGlobal = da.ObjResult;
            }
            if (wb.ObjResult.Count > 0)
            {
                M2WBGlobal = wb.ObjResult;
            }
            if (smf.ObjResult.Count > 0)
            {
                M2SpecialMoldFeatureGlobal = smf.ObjResult;
            }
            if(dpp.ObjResult.Count > 0)
            {
                M2DepopulatePinGlobal = dpp.ObjResult;
            }
            if (platT.ObjResult.Count > 0)
            {
                M2PlatingTypePublic = platT.ObjResult;
            }
            if (c5Pack.ObjResult.Count > 0)
            {
                C5PackageCodeGlobal = c5Pack.ObjResult;
            }
            if(DaF.ObjResult.Count > 0)
            {
                M2DAMandFillareaGlobal = DaF.ObjResult;

            }
        }

        private void buttonPkgH_Click(object sender, EventArgs e)
        {
            if (comboBoxPKGG.Text == "Normal" || comboBoxPKGG.Text == "MIS" || comboBoxPKGG.Text == "GQFN" || comboBoxPKGG.Text == "BGA")
            {
                var formPopup = new PackageHeight();
                formPopup.PkgHGlobal = PkgHGlobal;
                formPopup.MoldThicknessGlobal = MoldThicknessGlobal;
                formPopup.Status = "PkgH";
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxNo1.Text = formPopup.Code;
                    labelShow1.Text = "Mold= " + formPopup.Mold + "\nFrame= " + formPopup.Frame + "\nSubstrate= " + formPopup.Substrate;
                }
            }
            else
            {
                var formPopup = new PackageHeight();
                formPopup.m2PkgthicknessesGlobal = m2PkgthicknessesGlobal;
                formPopup.Status = "pkgTN";
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxNo1.Text = formPopup.Code;
                    labelShow1.Text = "Thickness = " + formPopup.Thickness;
                }
            }
        }

        private void buttonPkgType_Click(object sender, EventArgs e)
        {
            if (comboBoxPKGG.Text == "Normal" || comboBoxPKGG.Text == "MIS" || comboBoxPKGG.Text == "GQFN" || comboBoxPKGG.Text == "BGA")
            {
                var formPopup = new PackageHeight();
                formPopup.PkgTypeGlobal = PkgTypeGlobal;
                formPopup.Status = "PkgType";
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxNo2.Text = formPopup.Code;
                    labelShow2.Text = "Type= " + formPopup.Type;
                }
            }
        }

        private void textBoxPkgH_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxPKGG.Text == "QFP")
            {
                bool successfullyParsed = int.TryParse(textBoxNo5.Text, out int result);
                if (!successfullyParsed && textBoxNo5.Text != "")
                {
                    MessageBox.Show("กรุณากรอกตัวเลข 0-9");
                    textBoxNo5.Text = "";
                }
                bool successfullyParsed2 = int.TryParse(textBoxNo6.Text, out int result2);
                if (!successfullyParsed2 && textBoxNo6.Text != "")
                {
                    MessageBox.Show("กรุณากรอกตัวเลข 0-9");
                    textBoxNo6.Text = "";
                }
                bool successfullyParsed3 = int.TryParse(textBoxNo7.Text, out int result3);
                if (!successfullyParsed3 && textBoxNo7.Text != "")
                {
                    MessageBox.Show("กรุณากรอกตัวเลข 0-9");
                    textBoxNo7.Text = "";
                }
            }
            if(comboBoxPKGG.Text == "SMD" || comboBoxPKGG.Text == "SMART CARD")
            {
                bool successfullyParsed = int.TryParse(textBoxNo6.Text, out int result);
                if (!successfullyParsed && textBoxNo6.Text != "")
                {
                    MessageBox.Show("กรุณากรอกตัวเลข 0-9");
                    textBoxNo6.Text = "";
                }
                bool successfullyParsed2 = int.TryParse(textBoxNo7.Text, out int result2);
                if (!successfullyParsed2 && textBoxNo7.Text != "")
                {
                    MessageBox.Show("กรุณากรอกตัวเลข 0-9");
                    textBoxNo7.Text = "";
                }
            }
            labelAll.Text = textBoxNo1.Text + textBoxNo2.Text + textBoxNo3.Text + textBoxNo4.Text + textBoxNo5.Text + textBoxNo6.Text + textBoxNo7.Text + textBoxNo8.Text + textBoxNo9.Text + textBoxNo10.Text + textBoxNo11.Text + textBoxNo12.Text + textBoxNo13.Text + textBoxNo14.Text + textBoxNo15.Text;
        }

        private void buttonspcode_Click(object sender, EventArgs e)
        {
            if (comboBoxPKGG.Text == "Normal" || comboBoxPKGG.Text == "MIS" || comboBoxPKGG.Text == "GQFN" || comboBoxPKGG.Text == "BGA")
            {
                var formPopup = new PackageHeight();
                formPopup.PkgSpGlobal = PkgSpGlobal;
                formPopup.Status = "PkgSp";
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxNo3.Text = formPopup.Code;
                    labelShow3.Text = "Data= " + formPopup.Data;
                }
            }
            if(comboBoxPKGG.Text == "SMD")
            {
                var formPopup = new PackageHeight();
                formPopup.C5PackageCodeGlobal = C5PackageCodeGlobal;
                formPopup.Status = "c5Pack";
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxNo1.Text = formPopup.Code1;
                    textBoxNo2.Text = formPopup.Code2;
                    textBoxNo3.Text = formPopup.Code3;
                    textBoxNo4.Text = formPopup.Code4;
                    textBoxNo5.Text = formPopup.Code5;

                    labelShow3.Text = "Full Code= " + formPopup.Fullcode;
                }
            }
        }

        private void buttonBdL_Click(object sender, EventArgs e)
        {
            if (comboBoxPKGG.Text == "Normal")
            {
                var formPopup = new Number();
                formPopup.IntDecimalGlobal = IntDecimalGlobal;
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxNo4.Text = formPopup.Code1;
                    textBoxNo5.Text = formPopup.Code2;
                    textBoxNo6.Text = formPopup.Code3;
                    labelShow5.Text = "BODY LENGTH = " + formPopup.No1 + "." + formPopup.No2 + formPopup.No3;

                }
            }


        }

        private void buttonControl_Click(object sender, EventArgs e)
        {
            if (comboBoxPKGG.Text == "Normal")
            {
                var formPopup = new PackageHeight();
                formPopup.ControlGlobal = ControlGlobal;
                formPopup.Status = "Con";
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxNo7.Text = formPopup.Code;
                    labelShow7.Text = "Control= " + formPopup.Control;
                }
            }
            if (comboBoxPKGG.Text == "MIS" || comboBoxPKGG.Text == "GQFN" || comboBoxPKGG.Text == "BGA")
            {
                var formPopup = new PackageHeight();
                formPopup.IntDecimalGlobal = IntDecimalGlobal;
                formPopup.Status = "Num";
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxNo7.Text = formPopup.Code;
                    labelShow7.Text = "No of Die= " + formPopup.No;
                }
            }
        }

        private void buttonBdW_Click(object sender, EventArgs e)
        {
            if (comboBoxPKGG.Text == "Normal")
            {
                var formPopup = new Number();
                formPopup.IntDecimalGlobal = IntDecimalGlobal;
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxNo8.Text = formPopup.Code1;
                    textBoxNo9.Text = formPopup.Code2;
                    textBoxNo10.Text = formPopup.Code3;
                    labelShow9.Text = "BODY WIDTH = " + formPopup.No1 + "." + formPopup.No2 + formPopup.No3;

                }
            }
            else
            {

                var formPopup = new PackageHeight();
                formPopup.M2DAGlobal = M2DAGlobal;
                formPopup.Status = "da";
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    char d1 = formPopup.Code[0];
                    char d2 = formPopup.Code[1];
                    textBoxNo9.Text = d1.ToString();
                    textBoxNo10.Text = d2.ToString();
                    labelShow9.Text = "D/A= " + formPopup.DA;
                }

            }
        }

        private void buttonPinBall_Click(object sender, EventArgs e)
        {
            if (comboBoxPKGG.Text == "Normal")
            {
                var formPopup = new PackageHeight();
                formPopup.PinBallCountGlobal = PinBallCountGlobal;
                formPopup.Status = "pbc";
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxNo12.Text = formPopup.Code1;
                    textBoxNo13.Text = formPopup.Code2;
                    textBoxNo14.Text = formPopup.Code3;

                    labelShow13.Text = "PinBall= " + formPopup.PinBall;
                }
            }
            if (comboBoxPKGG.Text == "MIS" || comboBoxPKGG.Text == "GQFN" || comboBoxPKGG.Text == "BGA")
            {
                var formPopup = new PackageHeight();
                formPopup.PackageThicknessAfterMoldGlobal = PackageThicknessAfterMoldGlobal;
                formPopup.Status = "tam";
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {

                    textBoxNo13.Text = formPopup.Code;
                    labelShow13.Text = "Thickness= " + formPopup.Thickness;
                }
            }
            if (comboBoxPKGG.Text == "QFP" || comboBoxPKGG.Text == "SMD" || comboBoxPKGG.Text == "SMART CARD")
            {
                var formPopup = new PackageHeight();
                formPopup.M2DepopulatePinGlobal = M2DepopulatePinGlobal;
                formPopup.Status = "dpp";
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    char d1 = formPopup.Code[0];
                    char d2 = formPopup.Code[1];
                    textBoxNo13.Text = d1.ToString();
                    textBoxNo14.Text = d2.ToString();
                    labelShow13.Text = "Depopulate = " + formPopup.Depopulate;
                }
            }
        }

        private void buttonLeadBall_Click(object sender, EventArgs e)
        {
            if (comboBoxPKGG.Text == "Normal")
            {
                var formPopup = new PackageHeight();
                formPopup.LeadBallPitchGlobal = LeadBallPitchGlobal;
                formPopup.Status = "lbp";
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxNo11.Text = formPopup.Code;
                    labelShow11.Text = "LeadBall= " + formPopup.Leadball;
                }
            }
            if (comboBoxPKGG.Text == "MIS" || comboBoxPKGG.Text == "GQFN" || comboBoxPKGG.Text == "BGA")
            {
                var formPopup = new PackageHeight();
                formPopup.PinBallCountGlobal = PinBallCountGlobal;
                formPopup.Status = "pbc";
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxNo10.Text = formPopup.Code1;
                    textBoxNo11.Text = formPopup.Code2;
                    textBoxNo12.Text = formPopup.Code3;

                    labelShow11.Text = "PinBall= " + formPopup.PinBall;
                }
            }
            if(comboBoxPKGG.Text == "QFP" || comboBoxPKGG.Text == "SMD" || comboBoxPKGG.Text == "SMART CARD")
            {
                var formPopup = new PackageHeight();
                formPopup.M2WBGlobal = M2WBGlobal;
                formPopup.Status = "wb";
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxNo11.Text = formPopup.Code;
                    labelShow11.Text = "W/B= " + formPopup.WB;
                }
            }
        }

        private void buttonFrameFlow_Click(object sender, EventArgs e)
        {
            if (comboBoxPKGG.Text == "Normal" || comboBoxPKGG.Text == "MIS" || comboBoxPKGG.Text == "GQFN" || comboBoxPKGG.Text == "BGA")
            {
                var formPopup = new PackageHeight();
                formPopup.FrameFlowTypeGlobal = FrameFlowTypeGlobal;
                formPopup.Status = "fft";
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxNo15.Text = formPopup.Code;
                    labelShow15.Text = "FrameFlow= " + formPopup.FrameFlow;
                }
            }
            else
            {
                var formPopup = new PackageHeight();
                formPopup.M2PlatingTypePublic = M2PlatingTypePublic;
                formPopup.Status = "platT";
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxNo15.Text = formPopup.Code;
                    labelShow15.Text = "Type= " + formPopup.Type;
                }
            }
        }

        private void comboBoxPKGG_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelShow1.Text = "";
            labelShow2.Text = "";
            labelShow3.Text = "";
            labelShow4.Text = "";
            labelShow5.Text = "";
            labelShow6.Text = "";
            labelShow7.Text = "";
            labelShow8.Text = "";
            labelShow9.Text = "";
            labelShow10.Text = "";
            labelShow11.Text = "";
            labelShow12.Text = "";
            labelShow13.Text = "";
            labelShow14.Text = "";
            labelShow15.Text = "";
            textBoxNo1.Text = "";
            textBoxNo2.Text = "";
            textBoxNo3.Text = "";
            textBoxNo4.Text = "";
            textBoxNo5.Text = "";
            textBoxNo6.Text = "";
            textBoxNo7.Text = "";
            textBoxNo8.Text = "";
            textBoxNo9.Text = "";
            textBoxNo10.Text = "";
            textBoxNo11.Text = "";
            textBoxNo12.Text = "";
            textBoxNo13.Text = "";
            textBoxNo14.Text = "";
            textBoxNo15.Text = "";
            labelNo6.ForeColor = Color.Black;
            labelNo7.ForeColor = Color.Black;

            tableLayoutPanelNo1.BackColor = oc1;
            tableLayoutPanelNo2.BackColor = oc2;
            tableLayoutPanelNo3.BackColor = oc3;
            tableLayoutPanelNo4.BackColor = oc4;
            tableLayoutPanelNo5.BackColor = oc5;
            tableLayoutPanelNo6.BackColor = oc6;
            tableLayoutPanelNo7.BackColor = oc7;
            tableLayoutPanelNo8.BackColor = oc8;
            tableLayoutPanelNo9.BackColor = oc9;
            tableLayoutPanelNo10.BackColor = oc10;
            tableLayoutPanelNo11.BackColor = oc11;
            tableLayoutPanelNo12.BackColor = oc12;
            tableLayoutPanelNo13.BackColor = oc13;
            tableLayoutPanelNo14.BackColor = oc14;
            tableLayoutPanelNo15.BackColor = oc15;



            labelAll.Text = "";
            switch (comboBoxPKGG.Text)
            {
                case "Normal":
                    labelNo1.Text = "Package Height Frame / Mold Thickness";
                    labelNo2.Text = "Package Type";
                    labelNo3.Text = "Package Special Code";
                    labelNo4.Text = "Body Length";
                    labelNo5.Text = "Body Length";
                    labelNo6.Text = "Body Length";
                    labelNo7.Text = "Control 4th - 10th";
                    labelNo8.Text = "Body Width";
                    labelNo9.Text = "Body Width";
                    labelNo10.Text = "Body Width";
                    labelNo11.Text = "Lead Pitch/Ball Pitch";
                    labelNo12.Text = "Pin Count/Ball Count";
                    labelNo13.Text = "Pin Count/Ball Count";
                    labelNo14.Text = "Pin Count/Ball Count";
                    labelNo15.Text = "Frame Type & Flow Type";

                    buttonNo1.Visible = true;
                    buttonNo2.Visible = true;
                    buttonNo3.Visible = true;
                    
                    buttonNo4.Visible = false;
                    buttonNo5.Visible = true;
                    buttonNo6.Visible = false;
                    tableLayoutPanelNo4.BackColor = oc5;
                    tableLayoutPanelNo6.BackColor = oc5;


                    buttonNo7.Visible = true;

                    buttonNo8.Visible = false;
                    buttonNo9.Visible = true;
                    buttonNo10.Visible = false;
                    tableLayoutPanelNo8.BackColor = oc9;
                    tableLayoutPanelNo10.BackColor = oc9;

                    buttonNo11.Visible = true;

                    buttonNo12.Visible = false;
                    buttonNo13.Visible = true;
                    buttonNo14.Visible = false;
                    tableLayoutPanelNo12.BackColor = oc13;
                    tableLayoutPanelNo14.BackColor = oc13;

                    buttonNo15.Visible = true;

                    break;
                case "MIS":
                    labelNo1.Text = "Package Height Frame / Mold Thickness";
                    labelNo2.Text = "Package Type";
                    labelNo3.Text = "Package Special Code";
                    labelNo4.Text = "Body Length";
                    labelNo5.Text = "Body Length";
                    labelNo6.Text = "Control 4th - 9th";
                    labelNo7.Text = "Number of Die";
                    labelNo8.Text = "Body Width";
                    labelNo9.Text = "Body Width";
                    labelNo10.Text = "Ball Count/Pin Count";
                    labelNo11.Text = "Ball Count/Pin Count";
                    labelNo12.Text = "Ball Count/Pin Count";
                    labelNo13.Text = "Package Thickness After Mold Process";
                    labelNo14.Text = "Ball Height";
                    labelNo15.Text = "Frame Type & Flow Type";

                    buttonNo1.Visible = true;
                    buttonNo2.Visible = true;
                    buttonNo3.Visible = true;
                    buttonNo4.Visible = true;
                    buttonNo5.Visible = false;
                    tableLayoutPanelNo5.BackColor = oc4;

                    buttonNo6.Visible = true;
                    buttonNo7.Visible = true;
                    buttonNo8.Visible = true;
                    buttonNo9.Visible = false;
                    tableLayoutPanelNo9.BackColor = oc8;

                    buttonNo10.Visible = false;
                    buttonNo11.Visible = true;
                    buttonNo12.Visible = false;
                    tableLayoutPanelNo10.BackColor = oc11;
                    tableLayoutPanelNo12.BackColor = oc11;

                    buttonNo13.Visible = true;
                    buttonNo14.Visible = true;
                    buttonNo15.Visible = true;
                    break;
                case "GQFN":
                    labelNo1.Text = "Package Height Frame / Mold Thickness";
                    labelNo2.Text = "Package Type";
                    labelNo3.Text = "Package Special Code";
                    labelNo4.Text = "Body Length";
                    labelNo5.Text = "Body Length";
                    labelNo6.Text = "Control 4th - 9th";
                    labelNo7.Text = "Number of Die";
                    labelNo8.Text = "Body Width";
                    labelNo9.Text = "Body Width";
                    labelNo10.Text = "Ball Count/Pin Count";
                    labelNo11.Text = "Ball Count/Pin Count";
                    labelNo12.Text = "Ball Count/Pin Count";
                    labelNo13.Text = "Package Thickness After Mold Process";
                    labelNo14.Text = "Ball Height";
                    labelNo15.Text = "Frame Type & Flow Type";

                    buttonNo1.Visible = true;
                    buttonNo2.Visible = true;
                    buttonNo3.Visible = true;
                    buttonNo4.Visible = true;
                    buttonNo5.Visible = false;
                    tableLayoutPanelNo5.BackColor = oc4;
                    buttonNo6.Visible = true;
                    buttonNo7.Visible = true;
                    buttonNo8.Visible = true;
                    buttonNo9.Visible = false;
                    tableLayoutPanelNo9.BackColor = oc8;

                    buttonNo10.Visible = false;
                    buttonNo11.Visible = true;
                    buttonNo12.Visible = false;
                    tableLayoutPanelNo10.BackColor = oc11;
                    tableLayoutPanelNo12.BackColor = oc11;
                    buttonNo13.Visible = true;
                    buttonNo14.Visible = true;
                    buttonNo15.Visible = true;
                    break;
                case "BGA":
                    labelNo1.Text = "Package Height Frame / Mold Thickness";
                    labelNo2.Text = "Package Type";
                    labelNo3.Text = "Package Special Code";
                    labelNo4.Text = "Body Length";
                    labelNo5.Text = "Body Length";
                    labelNo6.Text = "Control 4th - 9th";
                    labelNo7.Text = "Number of Die";
                    labelNo8.Text = "Body Width";
                    labelNo9.Text = "Body Width";
                    labelNo10.Text = "Ball Count/Pin Count";
                    labelNo11.Text = "Ball Count/Pin Count";
                    labelNo12.Text = "Ball Count/Pin Count";
                    labelNo13.Text = "Package Thickness After Mold Process";
                    labelNo14.Text = "Ball Height";
                    labelNo15.Text = "Frame Type & Flow Type";

                    buttonNo1.Visible = true;
                    buttonNo2.Visible = true;
                    buttonNo3.Visible = true;
                    buttonNo4.Visible = true;
                    buttonNo5.Visible = false;
                    tableLayoutPanelNo5.BackColor = oc4;

                    buttonNo6.Visible = true;
                    buttonNo7.Visible = true;
                    buttonNo8.Visible = true;
                    buttonNo9.Visible = false;
                    tableLayoutPanelNo9.BackColor = oc8;

                    buttonNo10.Visible = false;
                    buttonNo11.Visible = true;
                    buttonNo12.Visible = false;
                    tableLayoutPanelNo10.BackColor = oc11;
                    tableLayoutPanelNo12.BackColor = oc11;
                    buttonNo13.Visible = true;
                    buttonNo14.Visible = true;
                    buttonNo15.Visible = true;
                    break;
                case "QFP":
                    labelNo1.Text = "Package Height Frame / Mold Thickness";
                    labelNo2.Text = "Package Type";
                    labelNo3.Text = "Package Special Code";
                    labelNo4.Text = "Package Size";
                    labelNo5.Text = "Pin count";
                    labelNo6.Text = "Pin count";
                    labelNo7.Text = "Pin count";
                    labelNo8.Text = "Leadframe type";
                    labelNo9.Text = "D/A";
                    labelNo10.Text = "D/A";
                    labelNo11.Text = "W/B";
                    labelNo12.Text = "Special mold feature";
                    labelNo13.Text = "Depopulate pin";
                    labelNo14.Text = "Depopulate pin";
                    labelNo15.Text = "Plating type";

                    buttonNo1.Visible = true;
                    buttonNo2.Visible = false;
                    buttonNo3.Visible = false;
                    buttonNo4.Visible = true;
                    buttonNo5.Visible = false;
                    buttonNo6.Visible = false;
                    buttonNo7.Visible = false;
                    tableLayoutPanelNo5.BackColor = oc6;
                    tableLayoutPanelNo7.BackColor = oc6;


                    buttonNo8.Visible = true;
                    buttonNo9.Visible = true;
                    buttonNo10.Visible = false;
                    tableLayoutPanelNo10.BackColor = oc9;

                    buttonNo11.Visible = true;
                    buttonNo12.Visible = true;
                    buttonNo13.Visible = true;
                    buttonNo14.Visible = false;
                    tableLayoutPanelNo14.BackColor = oc13;

                    buttonNo15.Visible = true;

                    textBoxNo2.Text = "Q";
                    textBoxNo3.Text = "F";
                    textBoxNo5.ReadOnly = false;
                    textBoxNo6.ReadOnly = false;
                    textBoxNo7.ReadOnly = false;
                    labelNo6.Text = "กรุณากรอกเลข 0-9";
                    labelNo6.ForeColor = Color.Red;

                    break;
                case "SMD":
                    labelNo1.Text = "Package Code";
                    labelNo2.Text = "Package Code";
                    labelNo3.Text = "Package Code";
                    labelNo4.Text = "Package Code";
                    labelNo5.Text = "Package Code";
                    labelNo6.Text = "Pin count";
                    labelNo7.Text = "Pin count";
                    labelNo8.Text = "Leadframe type";
                    labelNo9.Text = "D/A";
                    labelNo10.Text = "D/A";
                    labelNo11.Text = "W/B";
                    labelNo12.Text = "Special mold feature";
                    labelNo13.Text = "Depopulate pin";
                    labelNo14.Text = "Depopulate pin";
                    labelNo15.Text = "Plating type";

                    buttonNo1.Visible = false;
                    buttonNo2.Visible = false;
                    buttonNo3.Visible = true;
                    buttonNo4.Visible = false;
                    buttonNo5.Visible = false;
                    tableLayoutPanelNo1.BackColor = oc3;
                    tableLayoutPanelNo2.BackColor = oc3;
                    tableLayoutPanelNo4.BackColor = oc3;
                    tableLayoutPanelNo5.BackColor = oc3;


                    buttonNo6.Visible = false;
                    buttonNo7.Visible = false;
                    tableLayoutPanelNo7.BackColor = oc6;

                    buttonNo8.Visible = true;
                    buttonNo9.Visible = true;
                    buttonNo10.Visible = false;
                    tableLayoutPanelNo10.BackColor = oc9;

                    buttonNo11.Visible = true;
                    buttonNo12.Visible = true;
                    buttonNo13.Visible = true;
                    buttonNo14.Visible = false;
                    tableLayoutPanelNo14.BackColor = oc13;

                    buttonNo15.Visible = true;

                    textBoxNo6.ReadOnly = false;
                    textBoxNo7.ReadOnly = false;
                    labelNo7.Text = "กรุณากรอกเลข 0-9";
                    labelNo7.ForeColor = Color.Red;
                    break;
                case "SMART CARD":
                    labelNo1.Text = "Ecapulation thickness";
                    labelNo2.Text = "Package Code";
                    labelNo3.Text = "Package Code";
                    labelNo4.Text = "Dam&Fill Area";
                    labelNo5.Text = "Dam&Fill Area";
                    labelNo6.Text = "Pin count";
                    labelNo7.Text = "Pin count";
                    labelNo8.Text = "Leadframe type";
                    labelNo9.Text = "D/A";
                    labelNo10.Text = "D/A";
                    labelNo11.Text = "W/B";
                    labelNo12.Text = "Special mold feature";
                    labelNo13.Text = "Depopulate pin";
                    labelNo14.Text = "Depopulate pin";
                    labelNo15.Text = "Plating type";

                    buttonNo1.Visible = true;
                    buttonNo2.Visible = false;
                    buttonNo3.Visible = false;
                    buttonNo4.Visible = true;
                    buttonNo5.Visible = false;
                    tableLayoutPanelNo5.BackColor = oc4;

                    buttonNo6.Visible = false;
                    buttonNo7.Visible = false;
                    tableLayoutPanelNo7.BackColor = oc6;

                    buttonNo8.Visible = true;
                    buttonNo9.Visible = true;
                    buttonNo10.Visible = false;
                    tableLayoutPanelNo10.BackColor = oc9;

                    buttonNo11.Visible = true;
                    buttonNo12.Visible = true;
                    buttonNo13.Visible = true;
                    tableLayoutPanelNo14.BackColor = oc13;

                    buttonNo14.Visible = false;
                    buttonNo15.Visible = true;

                    textBoxNo2.Text = "S";
                    textBoxNo3.Text = "M";
                    textBoxNo6.ReadOnly = false;
                    textBoxNo7.ReadOnly = false;
                    labelNo7.Text = "กรุณากรอกเลข 0-9";
                    labelNo7.ForeColor = Color.Red;
                    break;
            }


        }

        private void buttonNo4_Click(object sender, EventArgs e)
        {
           
            
            
            if (comboBoxPKGG.Text == "MIS" || comboBoxPKGG.Text == "GQFN" || comboBoxPKGG.Text == "BGA")
            {
                var formPopup = new Number();
                formPopup.IntDecimalGlobal = IntDecimalGlobal;
                formPopup.pkgGroup = comboBoxPKGG.Text;
                formPopup.AnotherDecimalGlobal = AnotherDecimalGlobal;
                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxNo4.Text = formPopup.Code1;
                    textBoxNo5.Text = formPopup.Code2;
                    textBoxNo6.Text = formPopup.Code3;
                    labelShow4.Text = "BODY LENGTH = " + formPopup.No1 + "." + formPopup.No2 + formPopup.No3;

                }
            }
            if(comboBoxPKGG.Text == "QFP")
            {
                var formPopup = new PackageHeight();
                formPopup.m2PkgsizesGlobal = m2PkgsizesGlobal;
                formPopup.Status = "Siz";
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxNo4.Text = formPopup.Code;
                    labelShow4.Text = "Size= " + formPopup.Sizee;
                }
            }
            if (comboBoxPKGG.Text == "SMART CARD")
            {
                var formPopup = new PackageHeight();
                formPopup.M2DAMandFillareaGlobal = M2DAMandFillareaGlobal;
                formPopup.Status = "DaF";
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    char c1 = formPopup.Code[0];
                    char c2 = formPopup.Code[1];
                    textBoxNo4.Text = c1.ToString();
                    textBoxNo5.Text = c2.ToString();
                    labelShow4.Text = "Dam&Field Area= " + formPopup.DnFA;
                }
            }
        }

        private void buttonNo6_Click(object sender, EventArgs e)
        {
            if (comboBoxPKGG.Text == "MIS" || comboBoxPKGG.Text == "GQFN" || comboBoxPKGG.Text == "BGA")
            {
                var formPopup = new PackageHeight();
                formPopup.ControlGlobal = ControlGlobal;
                formPopup.Status = "Con";
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxNo6.Text = formPopup.Code;
                    labelShow6.Text = "Control= " + formPopup.Control;
                }
            }


        }

        private void buttonNo8_Click(object sender, EventArgs e)
        {
            if (comboBoxPKGG.Text == "MIS" || comboBoxPKGG.Text == "GQFN" || comboBoxPKGG.Text == "BGA")
            {
                var formPopup = new Number();
                formPopup.IntDecimalGlobal = IntDecimalGlobal;
                formPopup.AnotherDecimalGlobal = AnotherDecimalGlobal;
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxNo8.Text = formPopup.Code1;
                    textBoxNo9.Text = formPopup.Code2;
                    labelShow8.Text = "BODY WIDTH = " + formPopup.No1 + "." + formPopup.No2;

                }
            }
            else
            {
                var formPopup = new PackageHeight();
                formPopup.M2LeadframeTypesGlobal = M2LeadframeTypesGlobal;
                formPopup.Status = "lft";
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxNo8.Text = formPopup.Code;
                    labelShow8.Text = "Type = " + formPopup.Type;

                }
            }

        }

        private void buttonNo14_Click(object sender, EventArgs e)
        {
            if (comboBoxPKGG.Text == "MIS" || comboBoxPKGG.Text == "GQFN" || comboBoxPKGG.Text == "BGA")
            {
                var formPopup = new PackageHeight();
                formPopup.BallHeightGlobal = BallHeightGlobal;
                formPopup.Status = "bh";
                formPopup.pkgGroup = comboBoxPKGG.Text;

                if (formPopup.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxNo14.Text = formPopup.Code;
                    labelShow14.Text = "Ball Height = " + formPopup.HHeight;

                }
            }
        }

        private void buttonNo12_Click(object sender, EventArgs e)
        {
            var formPopup = new PackageHeight();
            formPopup.M2SpecialMoldFeatureGlobal = M2SpecialMoldFeatureGlobal;
            formPopup.Status = "smf";
            formPopup.pkgGroup = comboBoxPKGG.Text;

            if (formPopup.ShowDialog(this) == DialogResult.OK)
            {
                textBoxNo12.Text = formPopup.Code;
                labelShow12.Text = "Feature = " + formPopup.Feature;

            }
        }
    }
}
