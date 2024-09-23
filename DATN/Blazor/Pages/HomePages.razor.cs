using Microsoft.AspNetCore.Mvc;

namespace Blazor.Pages
{
    public partial class HomePages
    {
        private int CountStudent;

        private int CountTeacher;

        private HttpClient _http;

        protected override async Task OnInitializedAsync()
        {
            CountStudent = await ListStudent();
            CountTeacher = await ListTeach();
        }

        private async Task<int> ListStudent()
        {
            try
            {
                var result = await _http.GetFromJsonAsync<int>("api/Student/coute-student");

                return result;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private async Task<int> ListTeach()
        {
            try
            {
                var result = await _http.GetFromJsonAsync<int>("api/Teacher/coute-student");

                return result;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
