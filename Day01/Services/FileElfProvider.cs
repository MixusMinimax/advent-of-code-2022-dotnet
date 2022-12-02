using AdventOfCode.Models;
using Common.Extensions;

namespace AdventOfCode.Services;

public class FileElfProvider
{
    public List<Elf> GetElves(string path)
    {
        return File.ReadLines(path)
            .Select(line => int.TryParse(line, out var result) ? (int?)result : null)
            .ChunkBy(line => line is null)
            .Select(nums => new Elf(nums.Select(num => new Snack(num ?? 0)).ToList()))
            .ToList();
    }
}