public class SumCalculator
{
  protected readonly int[] _numbers;

  public SumCalculator(int[] numbers)
  {
    _numbers = numbers;
  }

  public virtual int Calculate() => _numbers.Sum();
}

public class EvenNumbersSumCalculator: SumCalculator
{
  public EvenNumbersSumCalculator(int[] numbers) : base(numbers)
  {
  }

  public override int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
}


