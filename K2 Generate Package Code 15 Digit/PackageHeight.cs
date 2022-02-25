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
    public partial class PackageHeight : Form
    {
        public PackageHeight()
        {
            InitializeComponent();
        }
        public List<DAL.PackageHeight> PkgHGlobal;
        public List<DAL.PackageType> PkgTypeGlobal;
        public List<DAL.PackageSpecialCode> PkgSpGlobal;
        public List<DAL.Control> ControlGlobal;
        public List<DAL.LeadBallPitch> LeadBallPitchGlobal;
        public List<DAL.PinBallCount> PinBallCountGlobal;
        public List<DAL.FrameFlowType> FrameFlowTypeGlobal;
        public List<DAL.MoldThickness> MoldThicknessGlobal;
        public List<DAL.IntDecimal> IntDecimalGlobal;
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
        public string Mold;
        public string Frame;
        public string Substrate;
        public string Code;
        public string Code1;
        public string Code2;
        public string Code3;
        public string Code4;
        public string Code5;
        public string Status;
        public string Type;
        public string Data;
        public string Control;
        public string Leadball;
        public string PinBall;
        public string FrameFlow;
        public string pkgGroup;
        public string No;
        public string Thickness;
        public string HHeight;
        public string Sizee;
        public string DA;
        public string WB;
        public string Feature;
        public string Depopulate;
        public string Fullcode;
        public string DnFA;
        private void PackageHeight_Load(object sender, EventArgs e)
        {

            switch (Status)
            {
                case "PkgH":
                    if (pkgGroup == "Normal")
                    {
                        var ppPkgH = from PkgHGlobal in PkgHGlobal select new { Mold = PkgHGlobal.Mold, Frame = PkgHGlobal.Frame, Substrate = PkgHGlobal.Substrate, Code = PkgHGlobal.Code };
                        dataGridViewShow.DataSource = ppPkgH.ToList();
                    }
                    else
                    {
                        var ppPkgH = from mt in MoldThicknessGlobal where mt.pkgGroup.Contains(pkgGroup) || mt.pkgGroup == "ALL" select new { Mold = mt.Mold, Frame = mt.Frame, Substrate = mt.Substrate, Other = mt.Other, Code = mt.Code };
                        dataGridViewShow.DataSource = ppPkgH.ToList();

                    }
                    break;
                case "PkgType":
                    var ppPkgType = from PkgTypeGlobal in PkgTypeGlobal where PkgTypeGlobal.pkgGroup.Contains(pkgGroup) select new { Type = PkgTypeGlobal.Type, Code = PkgTypeGlobal.Code };
                    dataGridViewShow.DataSource = ppPkgType.ToList();
                    break;
                case "PkgSp":
                    var ppPkgSp = from PkgSpGlobal in PkgSpGlobal select new { Data = PkgSpGlobal.Data, Code = PkgSpGlobal.Code };
                    dataGridViewShow.DataSource = ppPkgSp.ToList();
                    break;
                case "Con":
                    var ppCon = from ControlGlobal in ControlGlobal where ControlGlobal.pkgGroup.Contains(pkgGroup) select new { Control = ControlGlobal.Control1, Code = ControlGlobal.Code };
                    dataGridViewShow.DataSource = ppCon.ToList();
                    break;
                case "lbp":
                    var pplbp = from LeadBallPitchGlobal in LeadBallPitchGlobal select new { LeadBall = LeadBallPitchGlobal.LeadBall, Code = LeadBallPitchGlobal.Code };
                    dataGridViewShow.DataSource = pplbp.ToList();
                    break;
                case "pbc":
                    var pppbc = from PinBallCountGlobal in PinBallCountGlobal select new { PinBall = PinBallCountGlobal.PinBall, Code1 = PinBallCountGlobal.Code1, Code2 = PinBallCountGlobal.Code2, Code3 = PinBallCountGlobal.Code3 };
                    dataGridViewShow.DataSource = pppbc.ToList();
                    break;
                case "fft":
                    var ppfft = from FrameFlowTypeGlobal in FrameFlowTypeGlobal where FrameFlowTypeGlobal.pkgGroup.Contains(pkgGroup) || FrameFlowTypeGlobal.pkgGroup == "ALL" select new { FrameFlow = FrameFlowTypeGlobal.FrameFlow, Code = FrameFlowTypeGlobal.Code };
                    dataGridViewShow.DataSource = ppfft.ToList();
                    break;
                case "Num":
                    var ppNum = from nnn in IntDecimalGlobal select new { No = nnn.No, Code = nnn.Code };
                    dataGridViewShow.DataSource = ppNum.ToList();
                    break;
                case "tam":
                    var pptam = from pktam in PackageThicknessAfterMoldGlobal where pktam.pkgGroup.Contains(pkgGroup) || pktam.pkgGroup == "ALL" select new { Thickness = pktam.Thickness, Code = pktam.Code };
                    dataGridViewShow.DataSource = pptam.ToList();
                    break;
                case "bh":
                    var ppbh = from bhh in BallHeightGlobal select new { height = bhh.height, Code = bhh.Code };
                    dataGridViewShow.DataSource = ppbh.ToList();
                    break;
                case "pkgTN":
                    var ppkgTN = from pkgTN in m2PkgthicknessesGlobal where pkgTN.pkgGroup.Contains(pkgGroup) select new { thickness = pkgTN.thickness, Code = pkgTN.Code };
                    dataGridViewShow.DataSource = ppkgTN.ToList();
                    break;
                case "Siz":
                    var ppSiz = from Siz in m2PkgsizesGlobal select new { size = Siz.size, Code = Siz.Code };
                    dataGridViewShow.DataSource = ppSiz.ToList();
                    break;
                case "lft":
                    var pplft = from lft in M2LeadframeTypesGlobal where lft.pkgGroup.Contains(pkgGroup) select new { Type = lft.type, Code = lft.Code };
                    dataGridViewShow.DataSource = pplft.ToList();
                    break;
                case "da":
                    var ppda = from da in M2DAGlobal where da.pkgGroup.Contains(pkgGroup) select new { DA = da.da, Code = da.code };
                    dataGridViewShow.DataSource = ppda.ToList();
                    break;
                case "wb":
                    var ppwb = from wb in M2WBGlobal where wb.pkgGroup.Contains(pkgGroup) select new { WB = wb.WB, Code = wb.Code };
                    dataGridViewShow.DataSource = ppwb.ToList();
                    break;
                case "smf":
                    var ppsmf = from smf in M2SpecialMoldFeatureGlobal where smf.pkgGroup.Contains(pkgGroup) select new {feature  = smf.feature , Code = smf.Code };
                    dataGridViewShow.DataSource = ppsmf.ToList();
                    break;
                case "dpp":
                    var ppdpp = from dpp in M2DepopulatePinGlobal where dpp.pkgGroup.Contains(pkgGroup) select new { Dp = dpp.Dp, Code = dpp.Code };
                    dataGridViewShow.DataSource = ppdpp.ToList();
                    break;
                case "platT":
                    var ppPlatT = from platT in M2PlatingTypePublic where platT.pkgGroup.Contains(pkgGroup) select new { Type = platT.type, Code = platT.Code };
                    dataGridViewShow.DataSource = ppPlatT.ToList();
                    break;
                case "c5Pack":
                    var ppc5pack = from c5pack in C5PackageCodeGlobal select new { Fullcode = c5pack.fullcode, Code1 = c5pack.code1, Code2 = c5pack.code2, Code3 = c5pack.code3, Code4 = c5pack.code4, Code5 = c5pack.code5 };
                    dataGridViewShow.DataSource = ppc5pack.ToList();
                    break;
                case "DaF":
                    var ppDaf = from Dnf in M2DAMandFillareaGlobal select new { DamAndFieldArea = Dnf.DaF, Code = Dnf.Code };
                    dataGridViewShow.DataSource = ppDaf.ToList();
                    break;
            }


            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "Action";
            editButtonColumn.Text = "Action";

            if (dataGridViewShow.Columns["Action"] == null)
            {
                dataGridViewShow.Columns.Insert(0, editButtonColumn);
            }
            this.dataGridViewShow.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void dataGridViewShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewShow.Columns["Action"].Index && e.RowIndex >= 0)
            {
                switch (Status)
                {
                    case "PkgH":
                        Mold = (dataGridViewShow.Rows[e.RowIndex].Cells["Mold"].Value != null) ? dataGridViewShow.Rows[e.RowIndex].Cells["Mold"].Value.ToString() : "null";
                        Frame = (dataGridViewShow.Rows[e.RowIndex].Cells["Frame"].Value != null) ? dataGridViewShow.Rows[e.RowIndex].Cells["Frame"].Value.ToString() : "null";
                        Substrate = (dataGridViewShow.Rows[e.RowIndex].Cells["Substrate"].Value != null) ? dataGridViewShow.Rows[e.RowIndex].Cells["Substrate"].Value.ToString() : "null";
                        Code = dataGridViewShow.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                        DialogResult dR = MessageBox.Show("ต้องการเลือก " + Code + "\nMold = " + Mold + "\nFrame = " + Frame + "\nSubstrate = " + Substrate + "\nใช่หรือไม่?", "Confirm?", MessageBoxButtons.OKCancel);
                        if (dR == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case "PkgType":
                        Code = dataGridViewShow.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                        Type = (dataGridViewShow.Rows[e.RowIndex].Cells["Type"].Value != null) ? dataGridViewShow.Rows[e.RowIndex].Cells["Type"].Value.ToString() : "null";
                        DialogResult dR2 = MessageBox.Show("ต้องการเลือก " + Code + "\nType = " + Type + "\nใช่หรือไม่?", "Confirm?", MessageBoxButtons.OKCancel);
                        if (dR2 == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case "PkgSp":
                        Code = dataGridViewShow.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                        Data = (dataGridViewShow.Rows[e.RowIndex].Cells["Data"].Value != null) ? dataGridViewShow.Rows[e.RowIndex].Cells["Data"].Value.ToString() : "null";
                        DialogResult dR3 = MessageBox.Show("ต้องการเลือก " + Code + "\nData = " + Data + "\nใช่หรือไม่?", "Confirm?", MessageBoxButtons.OKCancel);
                        if (dR3 == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case "Con":
                        Code = dataGridViewShow.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                        Control = (dataGridViewShow.Rows[e.RowIndex].Cells["Control"].Value != null) ? dataGridViewShow.Rows[e.RowIndex].Cells["Control"].Value.ToString() : "null";
                        DialogResult dR4 = MessageBox.Show("ต้องการเลือก " + Code + "\nControl = " + Control + "\nใช่หรือไม่?", "Confirm?", MessageBoxButtons.OKCancel);
                        if (dR4 == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case "lbp":
                        Code = dataGridViewShow.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                        Leadball = (dataGridViewShow.Rows[e.RowIndex].Cells["Leadball"].Value != null) ? dataGridViewShow.Rows[e.RowIndex].Cells["Leadball"].Value.ToString() : "null";
                        DialogResult dR5 = MessageBox.Show("ต้องการเลือก " + Code + "\nLeadBall = " + Leadball + "\nใช่หรือไม่?", "Confirm?", MessageBoxButtons.OKCancel);
                        if (dR5 == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case "pbc":
                        Code1 = dataGridViewShow.Rows[e.RowIndex].Cells["Code1"].Value.ToString();
                        Code2 = dataGridViewShow.Rows[e.RowIndex].Cells["Code2"].Value.ToString();
                        Code3 = dataGridViewShow.Rows[e.RowIndex].Cells["Code3"].Value.ToString();
                        PinBall = (dataGridViewShow.Rows[e.RowIndex].Cells["PinBall"].Value != null) ? dataGridViewShow.Rows[e.RowIndex].Cells["PinBall"].Value.ToString() : "null";
                        DialogResult dR6 = MessageBox.Show("ต้องการเลือก " + Code1 + Code2 + Code3 + "\nPinBall = " + PinBall + "\nใช่หรือไม่?", "Confirm?", MessageBoxButtons.OKCancel);
                        if (dR6 == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case "fft":
                        Code = dataGridViewShow.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                        FrameFlow = (dataGridViewShow.Rows[e.RowIndex].Cells["FrameFlow"].Value != null) ? dataGridViewShow.Rows[e.RowIndex].Cells["FrameFlow"].Value.ToString() : "null";
                        DialogResult dR7 = MessageBox.Show("ต้องการเลือก " + Code + "\nFrameFlow = " + FrameFlow + "\nใช่หรือไม่?", "Confirm?", MessageBoxButtons.OKCancel);
                        if (dR7 == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case "Num":
                        Code = dataGridViewShow.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                        No = (dataGridViewShow.Rows[e.RowIndex].Cells["No"].Value != null) ? dataGridViewShow.Rows[e.RowIndex].Cells["No"].Value.ToString() : "null";
                        DialogResult dR8 = MessageBox.Show("ต้องการเลือก " + Code + "\nNo = " + No + "\nใช่หรือไม่?", "Confirm?", MessageBoxButtons.OKCancel);
                        if (dR8 == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case "tam":
                        Code = dataGridViewShow.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                        Thickness = (dataGridViewShow.Rows[e.RowIndex].Cells["Thickness"].Value != null) ? dataGridViewShow.Rows[e.RowIndex].Cells["Thickness"].Value.ToString() : "null";
                        DialogResult dR9 = MessageBox.Show("ต้องการเลือก " + Code + "\nThickness = " + Thickness + "\nใช่หรือไม่?", "Confirm?", MessageBoxButtons.OKCancel);
                        if (dR9 == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case "bh":
                        Code = dataGridViewShow.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                        HHeight = (dataGridViewShow.Rows[e.RowIndex].Cells["height"].Value != null) ? dataGridViewShow.Rows[e.RowIndex].Cells["height"].Value.ToString() : "null";
                        DialogResult dR10 = MessageBox.Show("ต้องการเลือก " + Code + "\nHeight = " + HHeight + "\nใช่หรือไม่?", "Confirm?", MessageBoxButtons.OKCancel);
                        if (dR10 == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case "pkgTN":
                        Code = dataGridViewShow.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                        Thickness = (dataGridViewShow.Rows[e.RowIndex].Cells["thickness"].Value != null) ? dataGridViewShow.Rows[e.RowIndex].Cells["thickness"].Value.ToString() : "null";
                        DialogResult dR11 = MessageBox.Show("ต้องการเลือก " + Code + "\nThickness = " + Thickness + "\nใช่หรือไม่?", "Confirm?", MessageBoxButtons.OKCancel);
                        if (dR11 == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case "Siz":
                        Code = dataGridViewShow.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                        Sizee = (dataGridViewShow.Rows[e.RowIndex].Cells["size"].Value != null) ? dataGridViewShow.Rows[e.RowIndex].Cells["size"].Value.ToString() : "null";
                        DialogResult dR12 = MessageBox.Show("ต้องการเลือก " + Code + "\nSize = " + Sizee + "\nใช่หรือไม่?", "Confirm?", MessageBoxButtons.OKCancel);
                        if (dR12 == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case "lft":
                        Code = dataGridViewShow.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                        Type = (dataGridViewShow.Rows[e.RowIndex].Cells["Type"].Value != null) ? dataGridViewShow.Rows[e.RowIndex].Cells["Type"].Value.ToString() : "null";
                        DialogResult dR13 = MessageBox.Show("ต้องการเลือก " + Code + "\nType = " + Type + "\nใช่หรือไม่?", "Confirm?", MessageBoxButtons.OKCancel);
                        if (dR13 == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case "da":
                        Code = dataGridViewShow.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                        DA = (dataGridViewShow.Rows[e.RowIndex].Cells["da"].Value != null) ? dataGridViewShow.Rows[e.RowIndex].Cells["da"].Value.ToString() : "null";
                        DialogResult dR14 = MessageBox.Show("ต้องการเลือก " + Code + "\nD/A = " + DA + "\nใช่หรือไม่?", "Confirm?", MessageBoxButtons.OKCancel);
                        if (dR14 == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case "wb":
                        Code = dataGridViewShow.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                        WB = (dataGridViewShow.Rows[e.RowIndex].Cells["WB"].Value != null) ? dataGridViewShow.Rows[e.RowIndex].Cells["WB"].Value.ToString() : "null";
                        DialogResult dR15 = MessageBox.Show("ต้องการเลือก " + Code + "\nW/B = " + WB + "\nใช่หรือไม่?", "Confirm?", MessageBoxButtons.OKCancel);
                        if (dR15 == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;

                    case "smf":
                        Code = dataGridViewShow.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                        Feature = (dataGridViewShow.Rows[e.RowIndex].Cells["feature"].Value != null) ? dataGridViewShow.Rows[e.RowIndex].Cells["feature"].Value.ToString() : "null";
                        DialogResult dR16 = MessageBox.Show("ต้องการเลือก " + Code + "\nFeature = " + Feature + "\nใช่หรือไม่?", "Confirm?", MessageBoxButtons.OKCancel);
                        if (dR16 == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case "dpp":
                        Code = dataGridViewShow.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                        Depopulate = (dataGridViewShow.Rows[e.RowIndex].Cells["Dp"].Value != null) ? dataGridViewShow.Rows[e.RowIndex].Cells["Dp"].Value.ToString() : "null";
                        DialogResult dR17 = MessageBox.Show("ต้องการเลือก " + Code + "\nDepopulate = " + Depopulate + "\nใช่หรือไม่?", "Confirm?", MessageBoxButtons.OKCancel);
                        if (dR17 == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case "platT":
                        Code = dataGridViewShow.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                        Type = (dataGridViewShow.Rows[e.RowIndex].Cells["Type"].Value != null) ? dataGridViewShow.Rows[e.RowIndex].Cells["Type"].Value.ToString() : "null";
                        DialogResult dR18 = MessageBox.Show("ต้องการเลือก " + Code + "\nType = " + Depopulate + "\nใช่หรือไม่?", "Confirm?", MessageBoxButtons.OKCancel);
                        if (dR18 == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case "c5Pack":
                        Code1 = dataGridViewShow.Rows[e.RowIndex].Cells["Code1"].Value.ToString();
                        Code2 = dataGridViewShow.Rows[e.RowIndex].Cells["Code2"].Value.ToString();
                        Code3 = dataGridViewShow.Rows[e.RowIndex].Cells["Code3"].Value.ToString();
                        Code4 = dataGridViewShow.Rows[e.RowIndex].Cells["Code4"].Value.ToString();
                        Code5 = dataGridViewShow.Rows[e.RowIndex].Cells["Code5"].Value.ToString();
                        Fullcode = (dataGridViewShow.Rows[e.RowIndex].Cells["Fullcode"].Value != null) ? dataGridViewShow.Rows[e.RowIndex].Cells["Fullcode"].Value.ToString() : "null";
                        DialogResult dR19 = MessageBox.Show("ต้องการเลือก " + Code1+Code2+Code3+Code4+Code5 + "\nPackage Code = " + Fullcode + "\nใช่หรือไม่?", "Confirm?", MessageBoxButtons.OKCancel);
                        if (dR19 == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case "DaF":
                        Code = dataGridViewShow.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                        DnFA = (dataGridViewShow.Rows[e.RowIndex].Cells["DamAndFieldArea"].Value != null) ? dataGridViewShow.Rows[e.RowIndex].Cells["DamAndFieldArea"].Value.ToString() : "null";
                        DialogResult dR20 = MessageBox.Show("ต้องการเลือก " + Code + "\nDam and Field Area = " + DnFA + "\nใช่หรือไม่?", "Confirm?", MessageBoxButtons.OKCancel);
                        if (dR20 == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != null)
            {
                switch (Status)
                {
                    case "PkgH":
                        if (pkgGroup == "Normal")
                        {
                            var ppPkgH = from x in PkgHGlobal where x.Code.Contains(textBoxSearch.Text.ToUpper()) || x.Mold.ToString().Contains(textBoxSearch.Text) || x.Frame.ToString().Contains(textBoxSearch.Text) || x.Substrate.Contains(textBoxSearch.Text) select new { Mold = x.Mold, Frame = x.Frame, Substrate = x.Substrate, Code = x.Code };
                            if (ppPkgH != null)
                            {
                                dataGridViewShow.DataSource = ppPkgH.ToList();
                            }
                        }
                        else
                        {
                            var ppPkgH = from mt in MoldThicknessGlobal where( mt.Mold.ToString().Contains(textBoxSearch.Text) || mt.Frame.Contains(textBoxSearch.Text) || mt.Substrate.Contains(textBoxSearch.Text) || mt.Other.Contains(textBoxSearch.Text) || mt.Code.Contains(textBoxSearch.Text.ToUpper()) )&& (mt.pkgGroup.Contains(pkgGroup) || mt.pkgGroup == "ALL") select new { Mold = mt.Mold, Frame = mt.Frame, Substrate = mt.Substrate, Other = mt.Other, Code = mt.Code };
                            dataGridViewShow.DataSource = ppPkgH.ToList();

                        }
                        break;
                    case "PkgType":
                        var PkgType = from x2 in PkgTypeGlobal where (x2.Type.Contains(textBoxSearch.Text) || x2.Code.Contains(textBoxSearch.Text.ToUpper())) && x2.pkgGroup.Contains(pkgGroup) select new { Type = x2.Type, Code = x2.Code };
                        if (PkgType != null)
                        {
                            dataGridViewShow.DataSource = PkgType.ToList();
                        }
                        break;
                    case "PkgSp":
                        var PkgSp = from x3 in PkgSpGlobal where x3.Data.Contains(textBoxSearch.Text) || x3.Code.Contains(textBoxSearch.Text.ToUpper()) select new { Data = x3.Data, Code = x3.Code };
                        if (PkgSp != null)
                        {
                            dataGridViewShow.DataSource = PkgSp.ToList();
                        }
                        break;
                    case "Con":
                        var Con = from x4 in ControlGlobal where (x4.Control1.Contains(textBoxSearch.Text) || x4.Code.Contains(textBoxSearch.Text.ToUpper())) && x4.pkgGroup.Contains(pkgGroup) select new { Control = x4.Control1, Code = x4.Code };
                        if (Con != null)
                        {
                            dataGridViewShow.DataSource = Con.ToList();
                        }
                        break;
                    case "lbp":
                        var lbp = from x5 in LeadBallPitchGlobal where x5.LeadBall.Contains(textBoxSearch.Text) || x5.Code.Contains(textBoxSearch.Text.ToUpper()) select new { LeadBall = x5.LeadBall, Code = x5.Code };
                        if (lbp != null)
                        {
                            dataGridViewShow.DataSource = lbp.ToList();
                        }
                        break;
                    case "pbc":
                        var pbc = from x6 in PinBallCountGlobal where x6.PinBall.Contains(textBoxSearch.Text) || x6.Code1.Contains(textBoxSearch.Text.ToUpper()) || x6.Code2.Contains(textBoxSearch.Text.ToUpper()) || x6.Code3.Contains(textBoxSearch.Text.ToUpper()) select new { PinBall = x6.PinBall, Code1 = x6.Code1, Code2 = x6.Code2, Code3 = x6.Code3 };
                        if (pbc != null)
                        {
                            dataGridViewShow.DataSource = pbc.ToList();
                        }
                        break;
                    case "fft":
                        var fft = from x7 in FrameFlowTypeGlobal where (x7.FrameFlow.Contains(textBoxSearch.Text) || x7.Code.Contains(textBoxSearch.Text.ToUpper())) && x7.pkgGroup.Contains(pkgGroup) || x7.pkgGroup == "ALL"  select new { FrameFlow = x7.FrameFlow, Code = x7.Code };
                        if (fft != null)
                        {
                            dataGridViewShow.DataSource = fft.ToList();
                        }
                        break;
                    case "Num":
                        var Num = from x8 in IntDecimalGlobal where x8.No.Contains(textBoxSearch.Text) || x8.Code.Contains(textBoxSearch.Text.ToUpper()) select new { No = x8.No, Code = x8.Code };
                        if (Num != null)
                        {
                            dataGridViewShow.DataSource = Num.ToList();
                        }
                        break;
                    case "tam":
                        var tam = from x9 in PackageThicknessAfterMoldGlobal where (x9.Thickness.Contains(textBoxSearch.Text) || x9.Code.Contains(textBoxSearch.Text.ToUpper())) && (x9.pkgGroup.Contains(pkgGroup) || x9.pkgGroup == "ALL") select new { Thickness = x9.Thickness, Code = x9.Code };
                        if (tam != null)
                        {
                            dataGridViewShow.DataSource = tam.ToList();
                        }
                        break;
                    case "bh":
                        var bh = from x10 in BallHeightGlobal where x10.height.Contains(textBoxSearch.Text) || x10.Code.Contains(textBoxSearch.Text.ToUpper()) select new { Height = x10.height, Code = x10.Code };
                        if (bh != null)
                        {
                            dataGridViewShow.DataSource = bh.ToList();
                        }
                        break;
                    case "pkgTN":
                        var pkgTN = from x11 in m2PkgthicknessesGlobal where (x11.thickness.Contains(textBoxSearch.Text) || x11.Code.Contains(textBoxSearch.Text.ToUpper())) && x11.pkgGroup.Contains(pkgGroup) select new { thickness = x11.thickness, Code = x11.Code };
                        if (pkgTN != null)
                        {
                            dataGridViewShow.DataSource = pkgTN.ToList();
                        }
                        break;
                    case "Siz":
                        var Siz = from x12 in m2PkgsizesGlobal where x12.size.Contains(textBoxSearch.Text) || x12.Code.Contains(textBoxSearch.Text.ToUpper()) select new { size = x12.size, Code = x12.Code };
                        if (Siz != null)
                        {
                            dataGridViewShow.DataSource = Siz.ToList();
                        }
                        break;
                    case "lft":
                        var lft = from x13 in M2LeadframeTypesGlobal where( x13.type.Contains(textBoxSearch.Text) || x13.Code.Contains(textBoxSearch.Text.ToUpper()) )&& x13.pkgGroup.Contains(pkgGroup) select new { Type = x13.type, Code = x13.Code };
                        if (lft != null)
                        {
                            dataGridViewShow.DataSource = lft.ToList();
                        }
                        break;
                    case "da":
                        var da = from x14 in M2DAGlobal where (x14.da.Contains(textBoxSearch.Text) || x14.code.Contains(textBoxSearch.Text.ToUpper())) && x14.pkgGroup.Contains(pkgGroup)  select new { DA = x14.da, Code = x14.code };
                        if (da != null)
                        {
                            dataGridViewShow.DataSource = da.ToList();
                        }
                        break;
                    case "wb":
                        var wb = from x15 in M2WBGlobal where (x15.WB.Contains(textBoxSearch.Text) || x15.Code.Contains(textBoxSearch.Text.ToUpper()))&& x15.pkgGroup.Contains(pkgGroup) select new { WB = x15.WB, Code = x15.Code };
                        if (wb != null)
                        {
                            dataGridViewShow.DataSource = wb.ToList();
                        }
                        break;
                    case "smf":
                        var smf = from x16 in M2SpecialMoldFeatureGlobal where (x16.feature.Contains(textBoxSearch.Text) || x16.Code.Contains(textBoxSearch.Text.ToUpper())) && x16.pkgGroup.Contains(pkgGroup)  select new { feature = x16.feature, Code = x16.Code };
                        if (smf != null)
                        {
                            dataGridViewShow.DataSource = smf.ToList();
                        }
                        break;
                    case "dpp":
                        var dpp = from x17 in M2DepopulatePinGlobal where (x17.Dp.Contains(textBoxSearch.Text) || x17.Code.Contains(textBoxSearch.Text.ToUpper())) && x17.pkgGroup.Contains(pkgGroup) select new { Dp = x17.Dp, Code = x17.Code };
                        if (dpp != null)
                        {
                            dataGridViewShow.DataSource = dpp.ToList();
                        }
                        break;
                    case "platT":
                        var platT = from x18 in M2PlatingTypePublic where (x18.type.Contains(textBoxSearch.Text) || x18.Code.Contains(textBoxSearch.Text.ToUpper())) && x18.pkgGroup.Contains(pkgGroup) select new { Type = x18.type, Code = x18.Code };
                        if (platT != null)
                        {
                            dataGridViewShow.DataSource = platT.ToList();
                        }
                        break;
                    case "c5Pack":
                        var c5Pack = from x19 in C5PackageCodeGlobal where x19.fullcode.Contains(textBoxSearch.Text) || x19.code1.Contains(textBoxSearch.Text.ToUpper()) || x19.code1.Contains(textBoxSearch.Text.ToUpper()) || x19.code1.Contains(textBoxSearch.Text.ToUpper()) || x19.code1.Contains(textBoxSearch.Text.ToUpper()) || x19.code1.Contains(textBoxSearch.Text.ToUpper()) || x19.code2.Contains(textBoxSearch.Text.ToUpper()) || x19.code3.Contains(textBoxSearch.Text.ToUpper()) || x19.code4.Contains(textBoxSearch.Text.ToUpper()) || x19.code5.Contains(textBoxSearch.Text.ToUpper()) select new { Fullcode = x19.fullcode,Code1 = x19.code1,Code2 = x19.code2,Code3=x19.code3,Code4 = x19.code4,Code5 = x19.code5};
                        if (c5Pack != null)
                        {
                            dataGridViewShow.DataSource = c5Pack.ToList();
                        }
                        break;
                    case "DaF":
                        var DaF= from x20 in M2DAMandFillareaGlobal where x20.DaF.Contains(textBoxSearch.Text) || x20.Code.Contains(textBoxSearch.Text.ToUpper()) select new { DamAndFieldArea = x20.DaF, Code = x20.Code };
                        if (DaF != null)
                        {
                            dataGridViewShow.DataSource = DaF.ToList();
                        }
                        break;
                }
            }
        }

        private void dataGridViewShow_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                Image someImage = Properties.Resources.accept;

                var w = Properties.Resources.accept.Width;
                var h = Properties.Resources.accept.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(someImage, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
    }
}
