using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Se307_Lab3_Problem2
{
    class HardwareStore
    {

        private List<Component> componentList = new List<Component>();

        private ArrayList ram = new ArrayList();
        private ArrayList cpu = new ArrayList();
        private ArrayList motherboard = new ArrayList();
        private ArrayList cases = new ArrayList();
        private ArrayList powersupply = new ArrayList();
        private ArrayList opticaldrives = new ArrayList();
        private ArrayList gpu = new ArrayList();
        private ArrayList accesorries = new ArrayList();


        public HardwareStore()
        {

            Ram.Add("product_no1");
            Ram.Add("product_no2");
            Ram.Add("product_no3");
            Ram.Add("product_no4");

            Cpu.Add("product_no1");
            Cpu.Add("product_no2");
            Cpu.Add("product_no3");
            Cpu.Add("product_no4");

            Motherboard.Add("product_no1");
            Motherboard.Add("product_no2");
            Motherboard.Add("product_no3");
            Motherboard.Add("product_no4");

            Cases.Add("product_no1");
            Cases.Add("product_no2");
            Cases.Add("product_no3");
            Cases.Add("product_no4");

            Powersupply.Add("product_no1");
            Powersupply.Add("product_no2");
            Powersupply.Add("product_no3");
            Powersupply.Add("product_no4");

            Opticaldrives.Add("product_no1");
            Opticaldrives.Add("product_no2");
            Opticaldrives.Add("product_no3");
            Opticaldrives.Add("product_no4");

            Gpu.Add("product_no1");
            Gpu.Add("product_no2");
            Gpu.Add("product_no3");
            Gpu.Add("product_no4");

            Accesorries.Add("product_no1");
            Accesorries.Add("product_no2");
            Accesorries.Add("product_no3");
            Accesorries.Add("product_no4");

            ComponentList.Add(new Component("RAM", Ram));
            ComponentList.Add(new Component("CPU", Cpu));
            ComponentList.Add(new Component("MOTHERBOARD", motherboard));
            ComponentList.Add(new Component("CASES", cases));
            ComponentList.Add(new Component("POWERSUPPLY", Powersupply));
            ComponentList.Add(new Component("OPTICALDRIVES", Opticaldrives));
            ComponentList.Add(new Component("GPU", Gpu));
            ComponentList.Add(new Component("ACCESSORIES", Accesorries));
            //componentList.Add(new Component("Others",others));

        }
        public ArrayList Ram { get => ram; set => ram = value; }
        public ArrayList Cpu { get => cpu; set => cpu = value; }
        public ArrayList Motherboard { get => motherboard; set => motherboard = value; }
        public ArrayList Cases { get => cases; set => cases = value; }
        public ArrayList Powersupply { get => powersupply; set => powersupply = value; }
        public ArrayList Opticaldrives { get => opticaldrives; set => opticaldrives = value; }
        public ArrayList Gpu { get => gpu; set => gpu = value; }
        public ArrayList Accesorries { get => accesorries; set => accesorries = value; }
        internal List<Component> ComponentList { get => componentList; set => componentList = value; }



        public Component GetComponentbyName(string name)
        {


            foreach (Component c in this.componentList)
            {
                if (c.Name == name)
                {
                    return c;
                }
            }
            return null;
        }
        public void DisplayMenu()
        {
            Console.WriteLine("\n************************** M E N U*****************************");
            Console.WriteLine("1 -Search for a component");
            Console.WriteLine("2 -Get harware component list");
            Console.WriteLine("3 -Edit hardware component product");
            Console.WriteLine("-1 -Exit");
            Console.WriteLine("Please enter your choice (1,2,3 or -1)");
        }
    }
}

