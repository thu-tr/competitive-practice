#include <iostream>
#include <algorithm>
#include <cstdio>
#include <cassert>
#include <vector>
#include <map>

using namespace std;
template<typename K, typename V>
void print_map(std::map<K, V> const& m)
{
	for (auto const& pair : m) {
		std::cout << "{" << pair.first << ": " << pair.second << "}\n";
	}
}

void process(map<int,int> const& m) {
	int sum = 0;
	int i = 1;
	for (auto const& pair : m) {
		sum += pair.second * i;
		i++;
	}
	cout << sum << endl;
}

int main() {
	//assert(freopen("input.txt", "r", stdin));
	//assert(freopen("output.txt", "w", stdout));
	
	ios_base::sync_with_stdio(false);
	int tc;
	cin >> tc;
	
	for (int i = 0; i < tc; i++) {
		int pets;
		cin >> pets;
		map<int, int> count;
		map<int, int>::iterator it;
		for (int j = 0; j < pets; j++) {
			int cur;
			cin >> cur;
			it = count.find(cur);
			if (it != count.end()) {
				count[cur] += 1;
			}
			else {
				count[cur] = 1;
			}
		}
		cout << "Case #" << i + 1 << ": ";
		process(count);
	}

}
