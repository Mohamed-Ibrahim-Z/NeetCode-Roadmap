#include<iostream>
#include<vector>

using namespace std;
vector<int> twoSum(vector<int>& nums, int target)
{
	vector<int> out;
	for (int i = 0; i < nums.size(); i++)
	{
		for (int j = i+1; j < nums.size(); j++)
		{
			if (nums[i] + nums[j] == target)
			{
				out.push_back(i);
				out.push_back(j);
				return out;
			}
		}
	}

}
