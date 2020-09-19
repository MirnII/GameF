using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATCH_3._3
{
    class calculations
    {
        string Answer=null;
        public string calculatingPathOne(double CordinateX, double CordinateXT, double CordinateY, double CordinateYT )
        {
            double X = CordinateX - CordinateXT;
            double Y = CordinateY - CordinateYT;
            
            if(X == 50) Answer = "Canvas.Left";
             else if(X == -50) Answer = "Canvas.Right";
            else if(X==0)
            {
                if (Y == 50) Answer = "Canvas.Top";
                else if (Y == -50) Answer = "Canvas.Bottom";
            } 
            return Answer;
        }
        public string calculationsPathTwo()
        {
            if (Answer == "Canvas.Left") Answer = "Canvas.Right";
            if (Answer == "Canvas.Right") Answer = "Canvas.Left";
            if (Answer == "Canvas.Top") Answer = "Canvas.Bottom";
            if (Answer == "Canvas.Bottom") Answer = "Canvas.Top";
            return Answer;

        }

    }
}
