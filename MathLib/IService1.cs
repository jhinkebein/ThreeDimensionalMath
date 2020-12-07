using System;
using System.ServiceModel;

namespace MathLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface IService1
    {
        [OperationContract]
        double AreaOfCube(double a); //a = length of edge, cube area=6a^2

        [OperationContract]
        double AreaOfRectangularPrism(double l, double w, double h); //a=2(wl+hl+hw)

        [OperationContract]
        double AreaOfCylinder(double r, double h); //a=2*pi*r(r+h)

        [OperationContract]
        double AreaOfCone(double r, double l); //a=pi*r(r+l) where l is slant height
        
        //might add volume later but its 3am 12/7 so I'm leaning towards no
    }

}
