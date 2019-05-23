using System;
using System.Linq;
using System.Text;

namespace GeneticData
{
    public class Gene : IComparable
    {
        private const string OPERATORS = "+x/";
        private const string NUMBERS_CODE = "abcdefghijABCDEFGHIJ";
        private static readonly int[] NUMBERS = { -10, -1, -2, -3, -4, -5, -6, -7, -8, -9, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


        public static float MutationChance { get; set; } = 0.010f;

        public float Fitness { get; set; }
        public bool IsDominant { get; set; }

        private float value = float.NaN;
        public float Value
        {
            get
            {
                if (value != float.NaN)
                    return value;
                else
                {
                    ProcessDnaSequence();
                    return value;
                }
            }

            private set => this.value = value;
        }
        

        private static char RandomOperator => OPERATORS[ThreadSafeRandom.Next(0, OPERATORS.Length)];
        private static char RandomNumberCode
        {
            get
            {
                if (ThreadSafeRandom.Next(0, 2) == 0)
                    return NUMBERS_CODE[ThreadSafeRandom.Next(0, NUMBERS_CODE.Count())];
                else
                    return char.ToLower(NUMBERS_CODE[ThreadSafeRandom.Next(0, NUMBERS_CODE.Count())]);
            }
        }
        private static string RandomGeneBlock => RandomOperator.ToString() + RandomNumberCode.ToString();


        private StringBuilder dnaSequence;
        public StringBuilder DnaSequence
        {
            get => dnaSequence;
            set
            {
                dnaSequence = value;
                ProcessDnaSequence();
            }
        }
       
        public Gene(RandomizationType randomizationType)
        {
            switch (randomizationType)
            {
                case RandomizationType.Pattern:
                    RandomizePatternGene();
                    break;

                case RandomizationType.FullRandom:
                    Randomize();
                    break;

                case RandomizationType.Empty:
                    dnaSequence = new StringBuilder();
                    break;
            }
        }

        public Gene(int numberOfDigits) => RandomizeGene(numberOfDigits);

        public Gene(StringBuilder dnaSequence, bool isDominant)
        {
            DnaSequence = new StringBuilder(dnaSequence.ToString());
            IsDominant = isDominant;
        }

        /// <summary>
        /// New Gene with a random dominance
        /// </summary>
        /// <param name="dnaSequence"></param>
        public Gene(StringBuilder dnaSequence)
        {
            DnaSequence = new StringBuilder(dnaSequence.ToString());
            IsDominant = ThreadSafeRandom.TorF;
        }

        public Gene(Gene gene1, Gene gene2)
        {
            dnaSequence = MixGene(gene1.DnaSequence, gene2.DnaSequence);

            IsDominant = ThreadSafeRandom.TorF ? gene1.IsDominant : gene2.IsDominant;

            Mutate();
        }

        public Gene(Gene gene)
        {
            IsDominant = gene.IsDominant;
            Value = gene.Value;
            DnaSequence = new StringBuilder(gene.DnaSequence.ToString());
        }

        private static int CodeToNumber(char c) => NUMBERS[NUMBERS_CODE.IndexOf(c)];

        private static char NumberToCode(int number) => NUMBERS_CODE[number - 1];

        /// <summary>
        /// RandomizeGene with a random number of digts (between 4 and 25)
        /// </summary>
        public void Randomize() => RandomizeGene(ThreadSafeRandom.Next(4, 25));

        /// <summary>
        /// Creates a random genome
        /// </summary>
        /// <param name="numberOfDigits">Will always be an odd number</param>
        public void RandomizeGene(int numberOfDigits)
        {
            StringBuilder dnaSequence = new StringBuilder();

            //Always odd
            if (numberOfDigits % 2 == 0)
                numberOfDigits++;

            //First Value
            dnaSequence.Append(RandomNumberCode);

            //Generate random metaData
            for (int i = 0; i < (numberOfDigits - 1) / 2; i++)
                dnaSequence.Append(RandomGeneBlock);

            IsDominant = ThreadSafeRandom.TorF;

            DnaSequence = dnaSequence;
        }


        /// <summary>
        /// Creates a genome (((a x b + c)/ d) + e)x f
        /// </summary>
        /// <param name="numberOfDigits">Will always be an odd number</param>
        public void RandomizePatternGene()
        {
            StringBuilder dnaSequence = new StringBuilder();

            dnaSequence.Append(RandomNumberCode);
            dnaSequence.Append('x');
            dnaSequence.Append(RandomNumberCode); 
            dnaSequence.Append('+');
            dnaSequence.Append(RandomNumberCode);
            dnaSequence.Append('/');
            dnaSequence.Append(RandomNumberCode);
            dnaSequence.Append('+');
            dnaSequence.Append(RandomNumberCode);
            dnaSequence.Append('x');
            dnaSequence.Append(RandomNumberCode);

            IsDominant = ThreadSafeRandom.TorF;

            DnaSequence = dnaSequence;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>A string that shows the dnaSequence with numbers and parenthesis</returns>
        public string GetDnaSequenceReadable(bool withParanthesis)
        {
            StringBuilder stringValue = new StringBuilder(dnaSequence.ToString());

            if (withParanthesis)
            {
                for (int i = 0; i < dnaSequence.Length; i++)
                    if (dnaSequence[i] == 'x' || dnaSequence[i] == '/')
                        stringValue.Insert(0, '(');

                stringValue.Replace("x", ")x");
                stringValue.Replace("/", ")/");
                //stringValue.Replace("/0", "/1");
            }

            for (int i = 0; i < NUMBERS_CODE.Length; i++)
                stringValue.Replace(NUMBERS_CODE[i].ToString(), NUMBERS[i].ToString());

            return stringValue.ToString();
        }

        public void Mutate()
        {
            
            int length = dnaSequence.Length;
            for (int i = 0; i < length; i++)
            {
                double random = ThreadSafeRandom.NextDouble();

                if (i % 2 == 1 && random < MutationChance * 0.5)
                {
                    if (ThreadSafeRandom.NextDouble() < 0.60)
                    {
                        dnaSequence.Remove(i, 2);
                        i -= 2;
                        length -= 2;
                    }
                    else
                    {
                        dnaSequence.Insert(i, RandomOperator.ToString() + RandomNumberCode.ToString());
                        i += 2;
                        length += 2;
                    }
                }
                else if (random < MutationChance)
                {
                    if (i % 2 == 0)
                        dnaSequence[i] = RandomNumberCode;
                    else
                        dnaSequence[i] = RandomOperator;
                }

            }

            if (ThreadSafeRandom.NextDouble() < MutationChance)
                IsDominant = ThreadSafeRandom.TorF;

            ProcessDnaSequence();
        }        

        public static StringBuilder GetDnaSequenceByReadable(string readable)
        {
            StringBuilder stringValue = new StringBuilder(readable);

            stringValue.Replace(")", "");
            stringValue.Replace("(", "");

            for (int i = 0; i < NUMBERS.Length; i++)
                stringValue.Replace(NUMBERS[i].ToString(), NUMBERS_CODE[i].ToString());

            for (int i = 1; i < stringValue.Length; i += 2)
            {
                bool correct = false;

                foreach (char c in OPERATORS)
                    if (stringValue[i] == c)
                        correct = true;

                if (!correct)
                {
                    char c = stringValue[i];
                    stringValue.Remove(i, 1);
                    stringValue.Insert(i, "-" + Char.ToUpper(c));
                }
            }

            return stringValue;
        }

        public static Gene[] CrossingOver(Gene gene1, Gene gene2)
        {
            string dna1 = gene1.dnaSequence.ToString();
            string dna2 = gene2.dnaSequence.ToString();

            int size = dna1.Length >= dna2.Length ? dna1.Length : dna2.Length;

            Gene result1;
            Gene result2;

            bool r1Cross = ThreadSafeRandom.TorF;
            bool r2Cross = ThreadSafeRandom.TorF;

            if (!r1Cross)
                result1 = new Gene(gene1);
            else
            {
                result1 = new Gene(RandomizationType.Empty)
                {
                    IsDominant = gene1.IsDominant
                };
            }

            if (!r2Cross)
                result2 = new Gene(gene2);
            else
            {
                result2 = new Gene(RandomizationType.Empty)
                {
                    IsDominant = gene2.IsDominant
                };
            }

            if (r1Cross || r2Cross)
            {
                if (ThreadSafeRandom.TorF)
                {
                    if (r1Cross)
                        result1.dnaSequence.Append(dna1[0]);

                    if (r2Cross)
                        result2.dnaSequence.Append(dna2[0]);
                }
                else
                {
                    if (r1Cross)
                        result1.dnaSequence.Append(dna2[0]);

                    if (r2Cross)
                        result2.dnaSequence.Append(dna1[0]);
                }

                for (int i = 1; i < size; i += 2)
                {
                    if (ThreadSafeRandom.TorF)
                    {
                        if (r1Cross && i + 1 < dna1.Length)
                        {
                            result1.dnaSequence.Append(dna1[i] + dna1[i + 1].ToString());
                        }

                        if (r2Cross && i + 1 < dna2.Length)
                            result2.dnaSequence.Append(dna2[i] + dna2[i + 1].ToString());
                    }
                    else
                    {
                        if (r1Cross && i + 1 < dna2.Length)
                            result1.dnaSequence.Append(dna2[i] + dna2[i + 1].ToString());

                        if (r2Cross && i + 1 < dna1.Length)
                            result2.dnaSequence.Append(dna1[i] + dna1[i + 1].ToString());
                    }
                }
            }

            result1.Mutate();
            result2.Mutate();


            return new Gene[] { result1, result2 };
        }

        private void ProcessDnaSequence()
        {
            if (dnaSequence.Length > 0)
            {
                //Inicial number
                value = CodeToNumber(dnaSequence[0]);

                for (int i = 1; i < dnaSequence.Length; i += 2)
                {
                    char command = dnaSequence[i];
                    int number = CodeToNumber(dnaSequence[i + 1]);

                    switch (command)
                    {
                        case '+':
                            value += number;
                            break;

                        case '-':
                            value -= number;
                            break;

                        case 'x':
                            value *= number;
                            break;

                        case '/':
                            if (number != 0)
                                value /= number;
                            break;
                    }
                }
            }
            else
                value = float.NaN;
        }

        private static StringBuilder MixGene(StringBuilder dnaSequence1, StringBuilder dnaSequence2)
        {
            StringBuilder newDnaSequence = new StringBuilder("");
            int numberOfDigits;

            if (dnaSequence1.Length < dnaSequence2.Length)
                numberOfDigits = ThreadSafeRandom.Next(dnaSequence1.Length, dnaSequence2.Length);
            else
                numberOfDigits = ThreadSafeRandom.Next(dnaSequence2.Length, dnaSequence1.Length);


            //Starter number
            newDnaSequence.Append(ThreadSafeRandom.TorF ? dnaSequence1[0] : dnaSequence2[0]);

            //Random by slots
            for (int i = 1; i < numberOfDigits; i += 2)
            {
                bool chosenDna = ThreadSafeRandom.TorF;

                if (!chosenDna && dnaSequence1.Length - 1 < i + 1)
                    chosenDna = true;
                else if (chosenDna && dnaSequence2.Length - 1 < i + 1)
                    chosenDna = false;

                if (!chosenDna)
                {
                    //Use data1
                    newDnaSequence.Append(dnaSequence1[i]);
                    newDnaSequence.Append(dnaSequence1[i + 1]);
                }
                else
                {
                    //Use data2
                    newDnaSequence.Append(dnaSequence2[i]);
                    newDnaSequence.Append(dnaSequence2[i + 1]);
                }
            }

            return newDnaSequence;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            if (obj is Gene otherGene)
                return Fitness.CompareTo(otherGene.Fitness);
            else
                throw new ArgumentException("Object is not a Gene");
        }
    }
}

public enum RandomizationType{
    Pattern,
    FullRandom,
    Empty
}
