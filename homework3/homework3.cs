using System;



//矩形类
public class Rectangular
{

    public double width { get; set; }//宽
    public double height { get; set; }//长

    //构造函数
    public Rectangular(double height, double width)
    {
        this.height=height;
        this.width=width;
    }
    
    

    //面积Area属性
    public double Area {
        get{
        if (!IsValid()) throw new InvalidOperationException("形状不正确，不能计算面积");
        return width*height;
             }
                        }
   

    public bool IsValid()
    {
        if(width<=0 || height<=0)   return false;
        return true;
    }

}


//实现正方形类
public class Square { 

    public double width { get; set; }

    //计算面积
    public double Area
    {
        get
        {
            if (!IsValid()) throw new InvalidOperationException("形状不正确，无法计算面积");
                return width * width;
        }
            
    }

    public Square(double width)
    {
        this.width=width;   
    }

    //判断输入的参数是否合法性
    public bool IsValid()
    {
        if(width<=0) return false;
            return true ;   
    }
}


//三角形类
public class Triangular {
    //三角形的三条边
    double edge1;
    double edge2;
    double edge3;

    public Triangular(double edge1,double edge2,double edge3)
    {
        this.edge1=edge1;this.edge2=edge2;this.edge3=edge3;//初始化三条边

    }

    //判断形状是否合理
    public bool IsValid()
    {
        if(edge1<=0||edge2<=0||edge3<=0)return false;
        return true;
    }

    //计算面积
    public double Area
    {
        get
        {
            if (!IsValid()) throw new InvalidOperationException("形状错误，无法计算面积");
            double p = (edge1 + edge2 + edge3) / 2;
            return Math.Sqrt(p * (p - edge1) * (p - edge2) * (p - edge3));
        }
    }
}




