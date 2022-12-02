namespace AdventOfCode.Models;

public record struct Snack(int Calories);

public record Elf(List<Snack> Snacks)
{
    public int TotalCalories => Snacks.Sum(snack => snack.Calories);
};