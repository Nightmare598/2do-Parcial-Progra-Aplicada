﻿using System;

namespace Sebastian
{
    public class Company
    {

        private string _name; private double _saveproject;

        public string Name { get { return _name; } }
        public double SaveProject { get { return _saveproject; } }

        public Company(string name, double saveproject) //Error: Person en vez de Company y un punto y coma mal ubicado, falta de parentesis 
        { 
            _name = name; //Error: Error de typeo
            _saveproject = saveproject; //Error: Punto y coma mal colocado
        }

    public void Save(double save)
    {
        _saveproject += save; //Error: Punto y coma mal colocado
    }

    public void Spend(double save)
    {   //Esta es la funcion que no esta cumpliendo su cometido
        //Esto es debido a que existe un error de signos, se colocó + en vez de -
        _saveproject -= save;  //Error: Punto y coma mal colocado  2do Error: Se coloco un + en vez de -
    }
    public void ChangeName(string name)
    {
        _name = name;
    }

}
}
