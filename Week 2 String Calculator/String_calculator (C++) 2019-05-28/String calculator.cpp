#include <bits/stdc++.h>

using namespace std;

vector<string> separators = {",","\n"};

vector<string> split(const string &s){

    vector<string> ret = {};

    int max_len = 0;
    string copy = s;
    string check;
    for(auto &sep : separators){
        max_len = max(max_len,(int)sep.size());
        check = copy.substr(copy.size()-sep.size(),sep.size());
        if(check==sep){
            cout << "error: expected number but EOF found" << endl;
        }
    }

    for(int i=0;i+max_len-1<copy.size();i++){
        for(auto &sep : separators) {
            int len = sep.size();
            check = copy.substr(i, len);
            //cout << sep << ' ' << check << endl;
            if (sep == check) {
                string add = copy.substr(0, i);
                copy = copy.substr(i + len, copy.size() - add.size());
                i = 0;
                ret.push_back(add);
                break;
            }
        }
    }

    if(!copy.empty()){
        ret.push_back(copy);
    }

    return ret;
}

bool is_num(string &s){

    for(char c : s){
        if(c-'0'>9) return false;
    }

    return true;
}

double add(const string &add){

    string ret;
    double tot =0;

    auto v = split(add);
    vector<double> negatives = {};

    for(auto &i : v){
        if(is_num(i)) {
            double to_add = stod(i);
            if(to_add<0){
                negatives.push_back(to_add);
            }
            tot += to_add;
        }
        else{
            cout << "Expected number but string found"<< endl;
        }
    }

    if(!negatives.empty()){
        cout << "Negatives not allowed: ";
        for(auto i : negatives){
            cout << i << ' ';
        }
        cout << endl;
    }


    return tot;
}

pair<bool,pair<string,string>> new_delimiter(string s){

    pair<bool,pair<string,string>> ret = {false,{"",""}};

    if(s[0]=='/'&& s[1]=='/'){
        ret.first = true;
        for(int i = 2;i+2<s.size();i++){
            string check = s.substr(i,1);
            //cout << check << endl;
            if(check=="\n"){
                ret.second.second = s.substr(2,i-2);
                ret.second.first = s.substr(i+1,s.size()-ret.second.second.size());
                break;
            }
        }
    }
    return ret;
}



int main() {

    string s = "//---\n54,3\n5";
    //cin >> s;
    pair<bool, pair<string,string>> c = new_delimiter(s);
    if(c.first){
        separators.push_back(c.second.second);
        cout <<  add(c.second.first);
    }
    else{
        cout << add(s);
    }



    return 0;
}