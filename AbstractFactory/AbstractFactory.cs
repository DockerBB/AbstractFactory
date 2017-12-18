using System;

namespace Yizit.DesignModel.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public virtual IColor GetColor(string color) { return null; }
        public virtual IShape GetShape(string shape) { return null; }


    }
    //形状工厂，创建形状对象的工厂
    public class ShapeAbstractFactory : AbstractFactory
    {
        

        public override IShape GetShape(string shape)
        {
            switch (shape)
            {
                case "Rectangle": return new RectangleShape(); break;
                case "Square": return new SquareShape(); break;
                case "Circle": return new CircleShape(); break;
                default: return null;
            }
            
        }
    }
    //颜色工厂，创建颜色对象的工厂
    public class ColorAbstractFactory : AbstractFactory
    {
        public override IColor GetColor(string color)
        {
            switch (color)
            {
                case "Red": return new RedColor(); break;
                case "Green": return new GreenColor(); break;
                case "Blue": return new BlueColor(); break;
                default: return null;
            }
            
        }

        
    }
    public interface IShape
    {
        void Draw();
    }

    public class RectangleShape : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle的Draw方法");
        }
    }

    public class SquareShape : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Square的Draw方法");
        }
    }

    public class CircleShape : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle的Draw方法");
        }
    }

    public interface IColor
    {
        void Fill();
    }

    public class RedColor : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Red的Fill方法");
        }
    }

    public class GreenColor : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Green的Fill方法");
        }
    }

    public class BlueColor : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Blue的Fill方法");
        }
    }

    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string factory)
        {
            if (factory.Equals("Shape")) return new ShapeAbstractFactory();
            else if (factory.Equals("Color")) return new ColorAbstractFactory();
            else
                return null;
        }
    }
    public class Client{
        public static void Main(string[] args)
        {
            //获取形状工厂
            AbstractFactory shapeFactory = FactoryProducer.GetFactory("Shape");

            //获取形状为 Circle 的对象
            IShape shape1 = shapeFactory.GetShape("Circle");

            //调用 Circle 的 draw 方法
            shape1.Draw();

            //获取形状为 Rectangle 的对象
            IShape shape2 = shapeFactory.GetShape("Rectangle");

            //调用 Rectangle 的 draw 方法
            shape2.Draw();

            //获取形状为 Square 的对象
            IShape shape3 = shapeFactory.GetShape("Square");

            //调用 Square 的 draw 方法
            shape3.Draw();

            //获取颜色工厂
            AbstractFactory colorFactory = FactoryProducer.GetFactory("Color");

            //获取颜色为 Red 的对象
            IColor color1 = colorFactory.GetColor("Red");

            //调用 Red 的 fill 方法
            color1.Fill();

            //获取颜色为 Green 的对象
            IColor color2 = colorFactory.GetColor("Green");

            //调用 Green 的 fill 方法
            color2.Fill();

            //获取颜色为 Blue 的对象
            IColor color3 = colorFactory.GetColor("Blue");

            //调用 Blue 的 fill 方法
            color3.Fill();

            Console.ReadLine();
        }

    }
}

