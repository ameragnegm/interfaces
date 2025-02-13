using interfaces.Assignment1;
using interfaces.Assignment2;
using interfaces.Assignment3;
using interfaces.Assignment4;

namespace interfaces
{

   

    internal class Program
    {
        static void Main(string[] args)
        {
            //// Assignment One
            //Checkout c = new Checkout();
            //c.PaymentInfo("BankTransfer", 780);

            //// Assignment Two

            //IVehicle v1 = new MotorCycle();
            //IVehicle v2 = new Car();
            //IVehicle V3 = new Truck();

            //v1.Descripe();
            //v1.Start();
            //v2.Descripe();
            //v2.Start();
            //v2.Stop();
            //V3.Stop();
            //V3.Descripe();

            //// Assignment Three 

            //IMediaPlayer m = new Audio();
            //m.Play();
            //m.Stop();

            //Media media = new Media();
            //LiveStream stream = new LiveStream();   
            //Video V = new Video();
            //media.Play(stream);
            //media.Stop(V);

            // Assignment Four
            
            INotification notification = new PushNotification();
            notification.Send(" LOL ");





        }
    }
}
