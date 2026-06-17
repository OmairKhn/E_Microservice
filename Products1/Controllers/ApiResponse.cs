namespace Products1.Controllers
{
    internal class ApiResponse<T>
    {
        public int Data { get; set; }
        public int TotalCount { get; set; }
        public bool success { get; set; }
        public string Message { get; set; }
    }
}