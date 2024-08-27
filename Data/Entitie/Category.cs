namespace Data;

public class Category
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsActive { get; set; }
    
    //relations
    public List<Todo> Todos { get; set; }
}