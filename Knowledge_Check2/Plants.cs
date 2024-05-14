public class Plant
{
    public string Name { get; set; }
    public string PlantType { get; set; }
    public string WaterSchedule { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Type: {PlantType}, Water Schedule: {WaterSchedule}";
    }
}
