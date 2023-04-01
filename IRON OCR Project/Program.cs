
namespace IRON_OCR_Project
{
    public class Program
    {
        public static void Main()
        {

            string Front_ID_Card_Path = "ID-Face.jpg";
            string Back_ID_Card_Path = "";

            //var face_IdCard = new IDCardOCR("../../../Images/ID-Face.jpg", 24, "arabic_Face_rec", 900, 300, 1003, 800);
            //// scale = 24
            //face_IdCard.print_Front_ID_Info(true, true);


            // ----------------------------------------------- ====== > [ Front ID Card Data ] <====== ----------------------------------------------- 


            ////-------------------------------------------- [ Id card Face First Name => Done ( ✔️ 'using SingleWord mode') Need to remove extra dots ] -------------------------------------

            var face_IdCard_FName = new IDCardOCR($"../../../Images/{Front_ID_Card_Path}", 0, "arabic_Face_FName_Section", 870, 320, 1080, 110);
            // best scale = ----
            face_IdCard_FName.print_Front_ID_Info(false, true, false, true);

            ////-------------------------------------------- [ Id card Face Last Name => Done ( ✔️ 'using SingleWord mode') Need to remove extra hyphen ] -------------------------------------

            //var face_IdCard_LName = new IDCardOCR($"../../../Images/{Front_ID_Card_Path}", 0, "arabic_Face_LName_Section", 900, 430, 1080, 100);
            //// best scale = ----
            //face_IdCard_LName.print_Front_ID_Info(false, true, false, true);

            //-------------------------------------------- [ Id card Face Address Part 1 =>  ( O )  ] -------------------------------------

            //var face_IdCard_Address_Part1 = new IDCardOCR($"../../../Images/{Front_ID_Card_Path}", 0, "arabic_Face_Address_Part1_Section", 870, 600, 1080, 100);
            ////best scale = ----
            //face_IdCard_Address_Part1.print_Front_ID_Info(false, true, false, true);

            //-------------------------------------------- [ Id card Face Address Part 2 =>  Done ( ✔️ 'using SingleWord mode') ] -------------------------------------

            //var face_IdCard_Address_Part2 = new IDCardOCR($"../../../Images/{Front_ID_Card_Path}", 0, "arabic_Face_Address_Part2_Section", 900, 690, 1003, 100);
            //// best scale = ---
            //face_IdCard_Address_Part2.print_Front_ID_Info(false, true, false);


            ////-------------------------------------------- [ Id card Face ID Number =>  Done ( ✔️ 'using SingleWord mode') ] -------------------------------------

            //var face_IdCard_IDNum = new IDCardOCR($"../../../Images/{Front_ID_Card_Path}", 0, "arabic_Face_IDNum_Section", 890, 970, 1050, 130);
            //// best scale = ---
            //face_IdCard_IDNum.print_Front_ID_Info(false, true, false);

            // face_IdCard_IDNum.print_Front_ID_Info(false, true,true);  Not correct


            /// *************************************************************************************************************************************************


            // ----------------------------------------------- ====== > [ Back ID Card Data ] <====== ----------------------------------------------- 

            //var back_IdCard = new IDCardOCR($"../../../Images/{Back_ID_Card_Path}", 83, "arabic_Back_rec", 590, 80, 1030, 585);
            ////scale = ----
            //back_IdCard.print_Back_ID_Info(default, true, true);

            //-------------------------------------------- [ Id card Back Issue Date =>  Done ( ✔️ 'using SingleWord mode' ) ] -------------------------------------

            //var back_IdCard_IssueDate = new IDCardOCR($"../../../Images/{Back_ID_Card_Path}",0, "arabic_Back_IssueDate", 590, 60, 350, 100);
            ////scale = ----
            //back_IdCard_IssueDate.print_Back_ID_Info(true, true);

            //-------------------------------------------- [ Id card Back Job Part 1 =>   Done ( ✔️ 'using SingleWord mode' ) ] -------------------------------------

            //var back_IdCard_Job_Part1 = new IDCardOCR($"../../../Images/{Back_ID_Card_Path}", 0, "arabic_Back_Job_Part1", 990, 160, 650, 100);
            ////scale = ----
            //back_IdCard_Job_Part1.print_Back_ID_Info(default,true, true);

            //-------------------------------------------- [ Id card Back Job Part 2 =>   Done ( ✔️ 'using SingleWord mode' ) ] -------------------------------------

            //var back_IdCard_Job_Part2 = new IDCardOCR($"../../../Images/{Back_ID_Card_Path}", 0, "arabic_Back_Job_Part2", 650, 260, 980, 100);
            ////scale = ----
            //back_IdCard_Job_Part2.print_Back_ID_Info(default, true, true);

            //-------------------------------------------- [ Id card Back Gender =>  Done ( ✔️ 'using SingleWord mode' ) ] -------------------------------------

            //var back_IdCard_gender = new IDCardOCR($"../../../Images/{Back_ID_Card_Path}", 0, "arabic_Back_gender", 1450, 360, 180, 100);
            ////scale = ----
            //back_IdCard_gender.print_Back_ID_Info(true, true);

            //-------------------------------------------- [ Id card Back Religion => Done ( ✔️ 'using SingleWord mode' ) ] -------------------------------------

            //var back_IdCard_religion = new IDCardOCR($"../../../Images/{Back_ID_Card_Path}", 0, "arabic_Back_religion", 1100, 370, 300, 120);
            ////best scale = ----
            //back_IdCard_religion.print_Back_ID_Info(default, true, true);


            //-------------------------------------------- [ Id card Back Social Status => Done ( ✔️ 'using SingleWord mode' ) ] -------------------------------------

            //var back_IdCard_social_status = new IDCardOCR($"../../../Images/{Back_ID_Card_Path}", 0, "arabic_Back_social_status", 650, 365, 300, 120);
            ////scale = ----
            //back_IdCard_social_status.print_Back_ID_Info(false, true, true);

            //-------------------------------------------- [ Id card Back Husband =>  ( O ) ] -------------------------------------

            //var back_IdCard_husband = new IDCardOCR($"../../../Images/{Back_ID_Card_Path}", 0, "arabic_Back_husband", 650, 460, 1000, 100);
            //////scale = ----
            //back_IdCard_husband.print_Back_ID_Info(false, true, true);



            //-------------------------------------------- [ Id card Back Valid Date =>  Done ( ✔️ 'using SingleWord mode' ) but there is no / or \ ] -------------------------------------

            //var back_IdCard_valid_date = new IDCardOCR($"../../../Images/{Back_ID_Card_Path}", 0, "arabic_Back_valid_date", 550, 550, 550, 120);
            //back_IdCard_valid_date.print_Back_ID_Info(false, true, false, true);

        }
    }
}

