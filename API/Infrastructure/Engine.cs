using API.FluentAPI;
using API.Controls;

namespace API.Infrastructure
{
    public class Engine
    {
        public static Control Form()
        {
            return new Form();
        }

        public static Control Label(string text)
        {
            var label = new Label();
            label.Text = text;
            return label;
        }

        public static Control Body()
        {
            return new Body();
        }

        public static Control Container()
        {
            return new Container();
        }

        public static Control Input()
        {
            return new Input();
        }

        public static Table Table()
        {
            return new Table();
        }
    }
}
