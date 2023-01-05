#include<iostream>
#include<set>
#include<vector>
using namespace std;

bool ContainsDuplicate(vector<int>& nums) {
    set<int> s;
    s.insert(nums[0]);
    for (int i = 1; i < nums.size(); i++)
    {
        auto it = s.find(nums[i]);
        if (it == s.end())
            s.insert(nums[i]);
        else
            return true;
    }
    return false;

}

int main() {
    vector<int> nums;
    nums.push_back(1);
    nums.push_back(2);
    nums.push_back(3);
    nums.push_back(1);
    cout << ContainsDuplicate(nums);
    system("pause");
}