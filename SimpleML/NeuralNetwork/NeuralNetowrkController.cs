using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SimpleML.NeuralNetwork
{
    class NeuralNetowrkController
    {
        private int[] layers;
        private float[][] neurons;
        private float[][] biases;
        private float[][][] weights;
        private int[] activations;

        public float fitness = 0; 

        public NeuralNetowrkController(int[] layers)
        {
            this.layers = new int[layers.Length];

            for (int i = 0; i < layers.Length; i++)
            {
                this.layers[i] = layers[i];
            }

            //Add Initialization of neurons, Biases, Weights.
        }
    }
}
