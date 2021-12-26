
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    public static class Parser
    {
        public static void Parse(string instruction, Robot robot, int i, int j)
        {
            var place = robot.CurrentRoutine[i, j];


            switch (instruction)
            {
                case "start":
                    place.Instruction = new Start(robot);
                    place.Empty = false;
                    break;
                case "backward":
                    place.Instruction = new MoveBackward(robot);
                    place.Empty = false;
                    break;
                case "forward":
                    place.Instruction = new MoveForward(robot);
                    place.Empty = false;
                    break;
                case "right":
                    place.Instruction = new TurnRight(robot);
                    place.Empty = false;
                    break;
                case "left":
                    place.Instruction = new TurnLeft(robot);
                    place.Empty = false;
                    break;
                case "drop":
                    place.Instruction = new Drop(robot);
                    place.Empty = false;
                    break;
                case "call":
                    place.Instruction = new Call(robot);
                    place.Empty = false;
                    break;
                case "code":
                    place.Instruction = new BarcodeScanner(robot);
                    place.Empty = false;
                    break;
                case "branch":
                    place.Instruction = new Branch(robot);
                    place.Empty = false;
                    break;
                case "shape":
                    place.Instruction = new Kinect(robot);
                    place.Empty = false;
                    break;
                case "direction":
                    place.Instruction = new Compass(robot);
                    place.Empty = false;
                    break;
                case "distance":
                    place.Instruction = new Ultrasonic(robot);
                    place.Empty = false;
                    break;
                case "loaded":
                    place.Instruction = new Dumbbell(robot);
                    place.Empty = false;
                    break;
                case "color":
                    place.Instruction = new WebCam(robot);
                    place.Empty = false;
                    break;
                case "time":
                    place.Instruction = new Chronometer(robot);
                    place.Empty = false;
                    break;
                case "getAt":
                    place.Instruction = new GetAt(robot);
                    place.Empty = false;
                    break;
                case "setAt":
                    place.Instruction = new SetAt(robot);
                    place.Empty = false;
                    break;
                case "recCall":
                    place.Instruction = new RecCall(robot);
                    place.Empty = false;
                    break;
                case "routine":
                    place.Instruction = new SaveRoutine(robot);
                    place.Empty = false;
                    break;
                case "number":
                    place.Instruction = new Number(robot);
                    place.Empty = false;
                    break;
                case "zero":
                    place.Instruction = new Zero(robot);
                    place.Empty = false;
                    break;
                case "one":
                    place.Instruction = new One(robot);
                    place.Empty = false;
                    break;
                case "TE":
                    place.Instruction = new TE(robot);
                    place.Empty = false;
                    break;
                case "TN":
                    place.Instruction = new TN(robot);
                    place.Empty = false;
                    break;
                case "TS":
                    place.Instruction = new TS(robot);
                    place.Empty = false;
                    break;
                case "TW":
                    place.Instruction = new TW(robot);
                    place.Empty = false;
                    break;
                case "NE":
                    place.Instruction = new NE(robot);
                    place.Empty = false;
                    break;
                case "NW":
                    place.Instruction = new NW(robot);
                    place.Empty = false;
                    break;
                case "SE":
                    place.Instruction = new SE(robot);
                    place.Empty = false;
                    break;
                case "SW":
                    place.Instruction = new SW(robot);
                    place.Empty = false;
                    break;
                case "add":
                    place.Instruction = new Add(robot);
                    place.Empty = false;
                    break;
                case "and":
                    place.Instruction = new And(robot);
                    place.Empty = false;
                    break;
                case "console":
                    place.Instruction = new Print(robot);
                    place.Empty = false;
                    break;
                case "dec":
                    place.Instruction = new Dec(robot);
                    place.Empty = false;
                    break;
                case "div":
                    place.Instruction = new Div(robot);
                    place.Empty = false;
                    break;
                case "eq":
                    place.Instruction = new Eq(robot);
                    place.Empty = false;
                    break;
                case "geq":
                    place.Instruction = new Geq(robot);
                    place.Empty = false;
                    break;
                case "gt":
                    place.Instruction = new Gt(robot);
                    place.Empty = false;
                    break;
                case "inc":
                    place.Instruction = new Inc(robot);
                    place.Empty = false;
                    break;
                case "land":
                    place.Instruction = new Land(robot);
                    place.Empty = false;
                    break;
                case "leq":
                    place.Instruction = new Leq(robot);
                    place.Empty = false;
                    break;
                case "lnot":
                    place.Instruction = new Lnot(robot);
                    place.Empty = false;
                    break;
                case "lor":
                    place.Instruction = new Lor(robot);
                    place.Empty = false;
                    break;
                case "lt":
                    place.Instruction = new Lt(robot);
                    place.Empty = false;
                    break;
                case "lxor":
                    place.Instruction = new Lxor(robot);
                    place.Empty = false;
                    break;
                case "mod":
                    place.Instruction = new Mod(robot);
                    place.Empty = false;
                    break;
                case "mul":
                    place.Instruction = new Mul(robot);
                    place.Empty = false;
                    break;
                case "neq":
                    place.Instruction = new Neq(robot);
                    place.Empty = false;
                    break;
                case "not":
                    place.Instruction = new Not(robot);
                    place.Empty = false;
                    break;
                case "or":
                    place.Instruction = new Or(robot);
                    place.Empty = false;
                    break;
                case "return":
                    place.Instruction = new Return(robot);
                    place.Empty = false;
                    break;
                case "sub":
                    place.Instruction = new Sub(robot);
                    place.Empty = false;
                    break;
                case "ternary":
                    place.Instruction = new Ternary(robot);
                    place.Empty = false;
                    break;

                case "getA":
                    place.Instruction = new GetA(robot);
                    place.Empty = false;
                    break;
                case "getB":
                    place.Instruction = new GetB(robot);
                    place.Empty = false;
                    break;
                case "getC":
                    place.Instruction = new GetC(robot);
                    place.Empty = false;
                    break;
                case "getD":
                    place.Instruction = new GetD(robot);
                    place.Empty = false;
                    break;
                case "getE":
                    place.Instruction = new GetE(robot);
                    place.Empty = false;
                    break;
                case "getF":
                    place.Instruction = new GetF(robot);
                    place.Empty = false;
                    break;
                case "getG":
                    place.Instruction = new GetG(robot);
                    place.Empty = false;
                    break;
                case "getH":
                    place.Instruction = new GetH(robot);
                    place.Empty = false;
                    break;
                case "getI":
                    place.Instruction = new GetI(robot);
                    place.Empty = false;
                    break;
                case "getJ":
                    place.Instruction = new GetJ(robot);
                    place.Empty = false;
                    break;
                case "getK":
                    place.Instruction = new GetK(robot);
                    place.Empty = false;
                    break;
                case "getL":
                    place.Instruction = new GetL(robot);
                    place.Empty = false;
                    break;
                case "getM":
                    place.Instruction = new GetM(robot);
                    place.Empty = false;
                    break;
                case "getN":
                    place.Instruction = new GetN(robot);
                    place.Empty = false;
                    break;
                case "getO":
                    place.Instruction = new GetO(robot);
                    place.Empty = false;
                    break;
                case "getP":
                    place.Instruction = new GetP(robot);
                    place.Empty = false;
                    break;
                case "getQ":
                    place.Instruction = new GetQ(robot);
                    place.Empty = false;
                    break;
                case "getR":
                    place.Instruction = new GetR(robot);
                    place.Empty = false;
                    break;
                case "getS":
                    place.Instruction = new GetS(robot);
                    place.Empty = false;
                    break;
                case "getT":
                    place.Instruction = new GetT(robot);
                    place.Empty = false;
                    break;
                case "getU":
                    place.Instruction = new GetU(robot);
                    place.Empty = false;
                    break;
                case "getV":
                    place.Instruction = new GetV(robot);
                    place.Empty = false;
                    break;
                case "getW":
                    place.Instruction = new GetW(robot);
                    place.Empty = false;
                    break;
                case "getX":
                    place.Instruction = new GetX(robot);
                    place.Empty = false;
                    break;
                case "getY":
                    place.Instruction = new GetY(robot);
                    place.Empty = false;
                    break;
                case "getZ":
                    place.Instruction = new GetZ(robot);
                    place.Empty = false;
                    break;

                case "setA":
                    place.Instruction = new SetA(robot);
                    place.Empty = false;
                    break;
                case "setB":
                    place.Instruction = new SetB(robot);
                    place.Empty = false;
                    break;
                case "setC":
                    place.Instruction = new SetC(robot);
                    place.Empty = false;
                    break;
                case "setD":
                    place.Instruction = new SetD(robot);
                    place.Empty = false;
                    break;
                case "setE":
                    place.Instruction = new SetE(robot);
                    place.Empty = false;
                    break;
                case "setF":
                    place.Instruction = new SetF(robot);
                    place.Empty = false;
                    break;
                case "setG":
                    place.Instruction = new SetG(robot);
                    place.Empty = false;
                    break;
                case "setH":
                    place.Instruction = new SetH(robot);
                    place.Empty = false;
                    break;
                case "setI":
                    place.Instruction = new SetI(robot);
                    place.Empty = false;
                    break;
                case "setJ":
                    place.Instruction = new SetJ(robot);
                    place.Empty = false;
                    break;
                case "setK":
                    place.Instruction = new SetK(robot);
                    place.Empty = false;
                    break;
                case "setL":
                    place.Instruction = new SetL(robot);
                    place.Empty = false;
                    break;
                case "setM":
                    place.Instruction = new SetM(robot);
                    place.Empty = false;
                    break;
                case "setN":
                    place.Instruction = new SetN(robot);
                    place.Empty = false;
                    break;
                case "setO":
                    place.Instruction = new SetO(robot);
                    place.Empty = false;
                    break;
                case "setP":
                    place.Instruction = new SetP(robot);
                    place.Empty = false;
                    break;
                case "setQ":
                    place.Instruction = new SetQ(robot);
                    place.Empty = false;
                    break;
                case "setR":
                    place.Instruction = new SetR(robot);
                    place.Empty = false;
                    break;
                case "setS":
                    place.Instruction = new SetS(robot);
                    place.Empty = false;
                    break;
                case "setT":
                    place.Instruction = new SetT(robot);
                    place.Empty = false;
                    break;
                case "setU":
                    place.Instruction = new SetU(robot);
                    place.Empty = false;
                    break;
                case "setV":
                    place.Instruction = new SetV(robot);
                    place.Empty = false;
                    break;
                case "setW":
                    place.Instruction = new SetW(robot);
                    place.Empty = false;
                    break;
                case "setX":
                    place.Instruction = new SetX(robot);
                    place.Empty = false;
                    break;
                case "setY":
                    place.Instruction = new SetY(robot);
                    place.Empty = false;
                    break;
                case "setZ":
                    place.Instruction = new SetZ(robot);
                    place.Empty = false;
                    break;

            }
        }
    }
}
