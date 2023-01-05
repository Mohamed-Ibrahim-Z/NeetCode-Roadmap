#include<iostream>
using namespace std;
bool isAnagram(string s, string t) {
    if (s.size() != t.size())
        return false;
    for (int i = 0; i < s.size(); i++)
    {
        auto res = t.find(s[i]);
        if (res > t.size() || res < 0)
            return false;
        
        t.erase(res,1);
    }
    return true;
}
int main() {
    string s = "anagram", t = "nagaram";
    cout<< isAnagram(s, t);
    system("pause");
}