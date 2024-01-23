namespace BlazorServerApp.Data
{
    public class TodoItem
    {
        public string Todo { get; set; }
        public DateTime? Date { get; set; }

        public string GetDate()
        {
            return Date?.ToShortDateString();
        }
    }
}
