using Service.Interfaces;

namespace UniversityWPF.ViewModels
{
    public class ChartViewModel
    {
        private IStudentService _studentService;
        
        public ChartViewModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
    }
}
