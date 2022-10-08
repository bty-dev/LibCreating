namespace CarActions
{
    public class Car
    {
        string modelName;
        public Car(string modelName)
        {
            this.modelName = modelName;
        }

        public string getModelName()
        {
            return this.modelName;
        }

        public void openTheDoor()
        {
            Console.WriteLine("Door is open");
        }

        public void engineStart()
        {
            Console.WriteLine("Engine is started!");
        }
    }
}