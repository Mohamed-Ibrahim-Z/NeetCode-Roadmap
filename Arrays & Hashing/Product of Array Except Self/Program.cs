int[] ProductExceptSelf(int[] nums)
{
    int[] result = new int[nums.Length];
    int product = 1;
    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = product;
        product *= nums[i];
    }
    product = 1;
    for (int i = nums.Length - 1; i >= 0; i--)
    {
        result[i] *= product;
        product *= nums[i];
    }
    return result;
}
