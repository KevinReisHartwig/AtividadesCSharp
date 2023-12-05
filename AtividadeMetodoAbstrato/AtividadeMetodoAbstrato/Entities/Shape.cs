using System;
using System.Collections.Generic;
using AtividadeMetodoAbstrato.Enums;
using AtividadeMetodoAbstrato.Entities;

namespace AtividadeMetodoAbstrato.Entities {
    abstract class Shape {

        public Color Color { get; set; }

        public Shape(Color color) {
            Color = color;
        }

        public abstract double Area();
    }
}
