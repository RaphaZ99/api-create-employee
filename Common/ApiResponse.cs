namespace CRUDAPI.Common
{
    public class ApiResponse<T>
    {

        public bool Success { get; set; }

        public T Data { get; set; }

        public List<T> DataList { get; set; }

        public string ErrorMessage { get; set; }

    }
}
