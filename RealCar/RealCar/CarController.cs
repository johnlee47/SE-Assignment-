namespace RealCar
{
    public class CarController
    {
        private Car model;
        private CarProperties view;

        public CarController(Car model, CarProperties view)
        {
            this.model = model;
            this.view = view;
        }

        public void setCarName(string name)
        {
            model.setName(name);
        }

        public string getCarName()
        {
            return model.getName();
        }

        public void setCarColor(string color)
        {
            model.setColor(color);
        }

        public string getCarColor()
        {
            return model.getColor();
        }

        public void updateView()
        {
            view.printStudentDetails(model.getName(), model.getColor());
        }
    }
}