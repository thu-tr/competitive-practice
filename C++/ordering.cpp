#include <iostream>
#include <algorithm>
#include <cstdio>
#include <cassert>
#include <vector>
#include <map>
#include <string>

using namespace std;

void process(vector<int> vec) {
	string master = "A";
	int i = 0;
	//cout << vec.size();
	while (i < vec.size()) {
		// if there is an even block following end block
		if (i + 1 < vec.size()) {
			string l2 = "";
			for (int j = 0; j < vec[i + 1]; j++) {
				l2 = char(j + 65) + l2;
			}

			int diff = vec[i + 1] - vec[i];

			string l1 = "";
			for (int j = 0; j < vec[i]; j++) {
				if (j == vec[i] - 1 && diff > 0) {
					l1 = l1 + char(j + 66 + diff);
				}
				else {
					l1 = l1 + char(j + 66);
				}
			}

			master += l1 + l2;
		}
		//if the end block is odd
		else {
			string l1 = "";
			for (int j = 0; j < vec[i]; j++) {
				l1 = l1 + char(j + 66);
			}
			master += l1;
		}
		i += 2;
	}
	cout << master << endl;
}

int main()
{
	int tc;
	cin >> tc;

	for (int i = 0; i < tc; i++) {
		int block;
		cin >> block;
		//cout << "num bloc" << block << endl;
		vector<int> vec;
		for (int j = 0; j < block; j++) {
			int temp;
			cin >> temp;
			vec.push_back(temp);
			//cout << "size" << vec.size() << endl;
		}
		cout << "Case #" << i+1 << ": ";
		process(vec);
	}
}


