﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public abstract class Picture
    {
        public Painter PainterName { get; set; }
        public string PictureName { get; set; }
        public string Type { get; set; }
        public int YearCreated { get; set; }
        public Image Photo { get; set; }
        public string Feature { get; set; }
        public int Value { get; set; }
        public bool Copy { get; set; }
        public Picture() {}
        public Picture(Painter Pa, string Pi, string Ty,int Ya, Image Ph, int Va, string Fe, bool Co)
        {
            PainterName = Pa;
            PictureName = Pi;
            Type = Ty;
            YearCreated = Ya;
            Photo = Ph;
            Feature = Fe;
            Value = Va;
            Copy = Co;


        }
    }
    public class Portret : Picture
    {
        public string People { get; set; }
        public Portret() { }
        public Portret(Painter Pa, string Pi, string Ty, int Ya, Image Ph, int Va, string Fe, bool Co,string Pe) : base(Pa, Pi, Ty, Ya, Ph, Va, Fe, Co)
        {
            People = Pe;
        }

    }
    public class Landscape : Picture
    {
        public string View;
        public Landscape(Painter Pa, string Pi, string Ty, int Ya, Image Ph, int Va, string Fe, bool Co, string Vi) : base(Pa, Pi, Ty, Ya, Ph, Va, Fe, Co)
        {
            View = Vi;
        }
    }
    public class Painter
    {
        public string Country { get; set; }
        public string Name { get; set; }
        public string YearBorn { get; set; }
        public string YearDied { get; set; }
        public HashSet<Picture> Pictures { get; set; }
        public Painter() { }
        public Painter(string c, string n,string b,string d,HashSet<Picture> p)
        {
            Country = c;
            Name = n;
            YearBorn = b;
            YearDied = d;
            Pictures = p;
        } 
    }
    public class Galery
    {
        public string Country { get; set; }
        public string Name { get; set; }
        public int Tel { get; set; }
        public string Mail { get; set; }
        public HashSet<Picture> Picuture { get; set; }
        public Galery() { }
        public Galery(string c,string n,int t,string m,HashSet<Picture> p)
        {
            Country = c;
            Name = n;
            Tel = t;
            Mail = m;
            Picuture = p;
        }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
