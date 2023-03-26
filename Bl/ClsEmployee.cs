using EmployeeProjectEx.Models;

namespace EmployeeProjectEx.Bl
{
    public class ClsEmployee
    {
      public List<EmployeeModel> GetData()
        {
           var LstEmployees = new List<EmployeeModel>();

            EmployeeModel oEmployeeModel = new EmployeeModel();
            oEmployeeModel.Id = 1;
            oEmployeeModel.Title = "Branding & Logo Design";
            oEmployeeModel.Name = "Amar Eisa";
            oEmployeeModel.Email = "mu1@gmail.com";
            oEmployeeModel.ImgeName = "11.jpg";
            oEmployeeModel.Description = "....... سأظل أمشي ،،،،،،،،،،،، لا كما الطرقات تُمشِي ............ بل كما خَطْوي يُريد";
            LstEmployees.Add(oEmployeeModel);


            oEmployeeModel = new EmployeeModel();
            oEmployeeModel.Id = 2;
            oEmployeeModel.Title = "IT-Developer";
            oEmployeeModel.Name = "Musab Khunaijir";
            oEmployeeModel.Email = "mu10@gmail.com";
            oEmployeeModel.ImgeName = "22.jpg";
            oEmployeeModel.Description = "....... أشارككم ما أعرفه من معلومات وإن كانت بسيطة، فلعلها تمس فيكم شيئاً فتنفعكم";
            LstEmployees.Add(oEmployeeModel);

            oEmployeeModel = new EmployeeModel();
            oEmployeeModel.Id = 3;
            oEmployeeModel.Title = "ASP.NET Developer";
            oEmployeeModel.Name = "Eihap Khalid";
            oEmployeeModel.Email = "mu100@gmail.com";
            oEmployeeModel.ImgeName = "33.jpg";
            oEmployeeModel.Description = "اهتم بتنمية الاشياء الصغيره فالبذره تتحول الى شجره كبيره وتثمر بعد ان يتم رعايتها";
            LstEmployees.Add(oEmployeeModel);

            return LstEmployees;
        }

    public EmployeeModel Find(int id)
        {
            return new EmployeeModel();
        }
    }
}
