using System;
using System.Collections.Generic;

namespace GeneticData
{
    public class Chromosome : IComparable
    {
        public float Fitness { get; set; }

        public int NumberOfGenes => GeneListExpessed.Length;

        public ChromossomeConfig Config { get; }

        public Gene[] GeneListExpessed { get; }

        public Gene[] GeneListB { get; }

        public Gene[] GeneListA { get; }


        /// <summary>
        /// Retuns the expressed gene that are in 'i' index
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Gene this[int i] { get => GeneListExpessed[i]; }

        /// <summary>
        /// Creates a Chromossome with empty genes
        /// </summary>
        public Chromosome(int numberOfGenes, ChromossomeConfig config)
        {
            Config = config;

            GeneListExpessed = new Gene[numberOfGenes];

            if (Config == ChromossomeConfig.WithDominance)
            {
                GeneListA = new Gene[numberOfGenes];
                GeneListB = new Gene[numberOfGenes];
            }
        }

        /// <summary>
        /// Creates a Chromossome from a crossing 
        /// (The chromossomes must have the same config)
        /// </summary>
        /// <param name="chromossome1"></param>
        /// <param name="chromossome2"></param>
        public Chromosome(Chromosome chromossome1, Chromosome chromossome2)
        {
            if (chromossome1.Config != chromossome2.Config)
                throw new Exception("The chromossomes must have the same config");

            if (chromossome1.NumberOfGenes != chromossome2.NumberOfGenes)
                throw new Exception("The chromossomes must have the same number of genes");

            Config = chromossome1.Config;

            if (chromossome1.Config == ChromossomeConfig.WithDominance)
            {
                GeneListA = new Gene[chromossome1.NumberOfGenes];
                GeneListB = new Gene[chromossome1.NumberOfGenes];
                GeneListExpessed = new Gene[chromossome1.NumberOfGenes];

                for (int i = 0; i < chromossome1.NumberOfGenes; i++)
                {
                    Gene[] results1 = Gene.CrossingOver(chromossome1.GeneListA[i], chromossome1.GeneListB[i]);
                    Gene[] results2 = Gene.CrossingOver(chromossome2.GeneListB[i], chromossome2.GeneListA[i]);

                    GeneListA[i] = results1[ThreadSafeRandom.Next(0, 2)];
                    GeneListB[i] = results2[ThreadSafeRandom.Next(0, 2)];

                    if (GeneListA[i].IsDominant == GeneListB[i].IsDominant)
                    {
                        if (ThreadSafeRandom.TorF)
                            GeneListExpessed[i] = GeneListA[i];
                        else
                            GeneListExpessed[i] = GeneListB[i];
                    }
                    else
                    {
                        if (GeneListA[i].IsDominant)
                            GeneListExpessed[i] = GeneListA[i];
                        else
                            GeneListExpessed[i] = GeneListB[i];
                    }
                }
            }
            else
            {
                GeneListExpessed = new Gene[chromossome1.NumberOfGenes];

                for (int i = 0; i < chromossome1.NumberOfGenes; i++)
                    GeneListExpessed[i] = new Gene(chromossome1.GeneListExpessed[i], chromossome2.GeneListExpessed[i]);
            }


        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            if (obj is Chromosome otherChrmossome)
                return Fitness.CompareTo(otherChrmossome.Fitness);
            else
                throw new ArgumentException("Object is not a Chromossome");
        }

        public void Randomize(RandomizationType randomizationType)
        {
            for (int i = 0; i < NumberOfGenes; i++)
            {
                if (Config == ChromossomeConfig.WithDominance)
                {
                    GeneListA[i] = new Gene(randomizationType);
                    GeneListB[i] = new Gene(randomizationType);

                    if (i % 2 == 0)
                        GeneListExpessed[i] = GeneListA[i];
                    else
                        GeneListExpessed[i] = GeneListB[i];
                }
                else
                {
                    GeneListExpessed[i] = new Gene(randomizationType);
                }
            }
        }
    }

    public enum ChromossomeConfig
    {
        WithDominance = 1,
        NoDominance = 0
    }
}
