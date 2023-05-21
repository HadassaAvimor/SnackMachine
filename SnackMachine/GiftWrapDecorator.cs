using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine;
public class GiftWrapDecorator : ProductDecorator
{
    public GiftWrapDecorator(Product product) : base(product.Name, product.Price, product)
    {
    }
    public override string ToString()
    {
        return base.ToString() + " עם אריזת מתנה";
    }
}

    
