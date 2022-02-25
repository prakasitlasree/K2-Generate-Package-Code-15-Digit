using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K2_Generate_Package_Code_15_Digit.DAL;

namespace K2_Generate_Package_Code_15_Digit.Services
{
    public class MainServices
    {
        public Container.DefaultContainer GetPkgType()
        {
            var result = new Container.DefaultContainer();
            try
            {
                using (var ctx = new Entities())
                {
                    var ret = ctx.PackageTypes.ToList();
                    if (ret.Count > 0)
                    {
                        result.ObjResult = ret;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }
        public Container.DefaultContainer GetPkgH()
        {
            var result = new Container.DefaultContainer();
            try
            {
                using (var ctx = new Entities())
                {
                    var ret = ctx.PackageHeights.ToList();
                    if (ret.Count > 0)
                    {
                        result.ObjResult = ret;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        public Container.DefaultContainer GetPkgSpCode()
        {
            var result = new Container.DefaultContainer();
            try
            {
                using (var ctx = new Entities())
                {
                    var ret = ctx.PackageSpecialCodes.ToList();
                    if (ret.Count > 0)
                    {
                        result.ObjResult = ret;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }
        public Container.DefaultContainer GetIntDecimal()
        {
            var result = new Container.DefaultContainer();
            try
            {
                using (var ctx = new Entities())
                {
                    var ret = ctx.IntDecimals.ToList();
                    if (ret.Count > 0)
                    {
                        result.ObjResult = ret;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        public Container.DefaultContainer GetControl()
        {
            var result = new Container.DefaultContainer();
            try
            {
                using (var ctx = new Entities())
                {
                    var ret = ctx.Controls.ToList();
                    if (ret.Count > 0)
                    {
                        result.ObjResult = ret;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        public Container.DefaultContainer GetLeadBallPitch()
        {
            var result = new Container.DefaultContainer();
            try
            {
                using (var ctx = new Entities())
                {
                    var ret = ctx.LeadBallPitches.ToList();
                    if (ret.Count > 0)
                    {
                        result.ObjResult = ret;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        public Container.DefaultContainer GetPinBallCount()
        {
            var result = new Container.DefaultContainer();
            try
            {
                using (var ctx = new Entities())
                {
                    var ret = ctx.PinBallCounts.ToList();
                    if (ret.Count > 0)
                    {
                        result.ObjResult = ret;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }
        public Container.DefaultContainer GetFrameFlowType()
        {
            var result = new Container.DefaultContainer();
            try
            {
                using (var ctx = new Entities())
                {
                    var ret = ctx.FrameFlowTypes.ToList();
                    if (ret.Count > 0)
                    {
                        result.ObjResult = ret;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }
        public Container.DefaultContainer GetMoldThickness()
        {
            var result = new Container.DefaultContainer();
            try
            {
                using (var ctx = new Entities())
                {
                    var ret = ctx.MoldThicknesses.ToList();
                    if (ret.Count > 0)
                    {
                        result.ObjResult = ret;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }
        public Container.DefaultContainer AnotherDecimal()
        {
            var result = new Container.DefaultContainer();
            try
            {
                using (var ctx = new Entities())
                {
                    var ret = ctx.AnotherDecimals.ToList();
                    if (ret.Count > 0)
                    {
                        result.ObjResult = ret;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }
        public Container.DefaultContainer GetpkgThicknessAfterMold()
        {
            var result = new Container.DefaultContainer();
            try
            {
                using (var ctx = new Entities())
                {
                    var ret = ctx.PackageThicknessAfterMolds.ToList();
                    if (ret.Count > 0)
                    {
                        result.ObjResult = ret;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        public Container.DefaultContainer GetBallHeight()
        {
            var result = new Container.DefaultContainer();
            try
            {
                using (var ctx = new Entities())
                {
                    var ret = ctx.BallHeights.ToList();
                    if (ret.Count > 0)
                    {
                        result.ObjResult = ret;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        public Container.DefaultContainer GetPkgThickness()
        {
            var result = new Container.DefaultContainer();
            try
            {
                using (var ctx = new Entities())
                {
                    var ret = ctx.M2pkgthickness.ToList();
                    if (ret.Count > 0)
                    {
                        result.ObjResult = ret;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }
        public Container.DefaultContainer GetpkgSize()
        {
            var result = new Container.DefaultContainer();
            try
            {
                using (var ctx = new Entities())
                {
                    var ret = ctx.M2pkgsize.ToList();
                    if (ret.Count > 0)
                    {
                        result.ObjResult = ret;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }
        public Container.DefaultContainer GetLeadFrameType()
        {
            var result = new Container.DefaultContainer();
            try
            {
                using (var ctx = new Entities())
                {
                    var ret = ctx.M2LeadframeType.ToList();
                    if (ret.Count > 0)
                    {
                        result.ObjResult = ret;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        public Container.DefaultContainer GetDA()
        {
            var result = new Container.DefaultContainer();
            try
            {
                using (var ctx = new Entities())
                {
                    var ret = ctx.M2DA.ToList();
                    if (ret.Count > 0)
                    {
                        result.ObjResult = ret;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        public Container.DefaultContainer GetWB()
        {
            var result = new Container.DefaultContainer();
            try
            {
                using (var ctx = new Entities())
                {
                    var ret = ctx.M2WB.ToList();
                    if (ret.Count > 0)
                    {
                        result.ObjResult = ret;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        public Container.DefaultContainer GetSpecialMoldFeature()
        {
            var result = new Container.DefaultContainer();
            try
            {
                using (var ctx = new Entities())
                {
                    var ret = ctx.M2SpecialMoldFeature.ToList();
                    if (ret.Count > 0)
                    {
                        result.ObjResult = ret;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }
        public Container.DefaultContainer GetDepopulatePin()
        {
            var result = new Container.DefaultContainer();
            try
            {
                using (var ctx = new Entities())
                {
                    var ret = ctx.M2DepopulatePin.ToList();
                    if (ret.Count > 0)
                    {
                        result.ObjResult = ret;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }
        public Container.DefaultContainer GetPlatingType()
        {
            var result = new Container.DefaultContainer();
            try
            {
                using (var ctx = new Entities())
                {
                    var ret = ctx.M2PlatingType.ToList();
                    if (ret.Count > 0)
                    {
                        result.ObjResult = ret;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        public Container.DefaultContainer GetDamAndFieldArea()
        {
            var result = new Container.DefaultContainer();
            try
            {
                using (var ctx = new Entities())
                {
                    var ret = ctx.M2DAMandFillarea.ToList();
                    if (ret.Count > 0)
                    {
                        result.ObjResult = ret;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        public Container.DefaultContainer Get5pack()
        {
            var result = new Container.DefaultContainer();
            try
            {
                using (var ctx = new Entities())
                {
                    var ret = ctx.C5PackageCode.ToList();
                    if (ret.Count > 0)
                    {
                        result.ObjResult = ret;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }
    }
}
