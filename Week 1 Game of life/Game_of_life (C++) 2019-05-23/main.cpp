#include <bits/stdc++.h>

using namespace std;

int rows,cols;
char live_cell,dead_cell;
char grid[1000][1000];

int getcell(int x, int y){
    if(x>=0 && x<rows && y>=0 && y<cols) return grid[x][y]=='*'? 1:0;
    return 0;
}

void play(){

    for(int x =0;x<rows;x++){
        for(int y = 0;y<cols;y++){

            int cells = 0;

            cells+=getcell(x-1,y-1);
            cells+=getcell(x,y-1);
            cells+=getcell(x+1,y-1);
            cells+=getcell(x-1,y);
            cells+=getcell(x+1,y);
            cells+=getcell(x-1,y+1);
            cells+=getcell(x,y+1);
            cells+=getcell(x+1,y+1);

            if(cells<2||cells>3) grid[x][y]=dead_cell;
            else if(cells==3) grid[x][y]=live_cell;
        }
    }
}

void print_grid(){
    for(int x = 0;x<rows; x++){
        for(int y =0;y<cols;y++){
            cout << grid[x][y];
        }
        cout << endl;
    }
    cout << endl;
}

int main() {

    ifstream file("S:\\Desktop\\test.txt");
    string str;

    getline(file,str);
    rows = str[0]-'0';
    cols = str[2]-'0';
    live_cell = str[4];
    dead_cell = str[6];

    int x = 0;
    while(getline(file,str)){
        for(int y = 0;y<cols;y++){
            grid[x][y]=str[y];
        }
        x++;
    }

    print_grid();
    play();
    print_grid();
    return 0;
}