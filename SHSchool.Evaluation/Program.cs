﻿using FISCA.Permission;
using FISCA.Presentation;

namespace SHSchool.Evaluation
{
    public class Program
    {
        [FISCA.MainMethod()]
        public static void Main()
        {
            string userAclCode = "SHSchool.Evaluation.ImportProgramPlan";

            MotherForm.RibbonBarItems["教務作業", "資料統計"]["匯入"].Size = RibbonBarButton.MenuButtonSize.Large;
            MotherForm.RibbonBarItems["教務作業", "資料統計"]["匯入"].Image = Properties.Resources.Import_Image;
            MotherForm.RibbonBarItems["教務作業", "資料統計"]["匯入"]["匯入課程規劃"].Enable = UserAcl.Current[userAclCode].Executable;
            MotherForm.RibbonBarItems["教務作業", "資料統計"]["匯入"]["匯入課程規劃"].Click += (sender,e)=> new ImportProgramPlan().Execute();

            Catalog catalog01 = RoleAclSource.Instance["教務作業"]["功能按鈕"];
            catalog01.Add(new RibbonFeature(userAclCode, "匯入課程規劃"));
        }
    }
}