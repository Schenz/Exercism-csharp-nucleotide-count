using System;
using System.Collections.Generic;

public class NucleotideCount
{
    public NucleotideCount(string sequence)
    {
        NucleotideCounts = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        var seqArray = sequence.ToCharArray();
        foreach (var seq in seqArray)
        {
            if (NucleotideCounts.ContainsKey(seq))
            {
                NucleotideCounts[seq] = NucleotideCounts[seq] + 1;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public IDictionary<char, int> NucleotideCounts { get; set; }
}