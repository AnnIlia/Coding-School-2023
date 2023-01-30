namespace EF.Course.Model
{
    public class Todo
    {
        public Todo(string title) {
        Title = title;
        }

        public string Title { get; set; }
        public bool Finished { get; set; }

    }
}