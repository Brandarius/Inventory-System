using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Inventory2.Models
{
    // Abstract base class for all part types (InHouse or Outsourced)
    public abstract class Part
    {
        // Unique identifier for the part
        public int PartID { get; set; }

        // Name of the part
        public string Name { get; set; }

        // Price or cost of the part
        public decimal Price { get; set; }

        // Current inventory level
        public int InStock { get; set; }

        // Minimum allowed stock
        public int Min { get; set; }

        // Maximum allowed stock
        public int Max { get; set; }

        // Displays either MachineID or CompanyName depending on the derived type
        public virtual string SourceInfo { get; }

        // Constructor for the abstract Part class
        public Part(int partId, string name, decimal price, int inStock, int min, int max)
        {
            PartID = partId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
    }

    // Represents an in-house manufactured part with a machine ID
    public class InHousePart : Part
    {
        // ID of the machine used to manufacture this part
        public int MachineID { get; set; }

        // Constructor for InHousePart
        public InHousePart(int partId, string name, decimal price, int inStock, int min, int max, int machineId)
            : base(partId, name, price, inStock, min, max)
        {
            MachineID = machineId;
        }

        // Returns the machine ID as the source info
        public override string SourceInfo => MachineID.ToString();
    }

    // Represents an outsourced part with a company name
    public class OutsourcedPart : Part
    {
        // Name of the external company supplying this part
        public string CompanyName { get; set; }

        // Constructor for OutsourcedPart
        public OutsourcedPart(int partId, string name, decimal price, int inStock, int min, int max, string companyName)
            : base(partId, name, price, inStock, min, max)
        {
            CompanyName = companyName;
        }

        // Returns the company name as the source info
        public override string SourceInfo => CompanyName.ToString();
    }
}
