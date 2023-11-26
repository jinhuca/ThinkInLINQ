﻿namespace C0203;

file class Program
{
  static void Main(string[] args)
  {
    WeightedSum();
  }

  static void WeightedSum()
  {
    int[] values_ = { 1, 2, 3 };
    int[] weights_ = { 3, 2, 1 };

    var weight_ = values_
      .Zip(weights_, (value, weight) => value * weight)
      .Sum();

    Console.WriteLine(weight_);
  }
}