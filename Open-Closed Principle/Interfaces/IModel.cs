namespace Open_Closed_Principle
{
    public interface IModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccount AccountProccessor { get; set; }
    }
}