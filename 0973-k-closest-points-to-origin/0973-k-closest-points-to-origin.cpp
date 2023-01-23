class Solution {
public:
    vector<vector<int>> kClosest(vector<vector<int>>& points, int k) {
        vector<double> distance;
        for (int i = 0; i < points.size(); i++)
            distance.push_back(sqrt(pow(points[i].front(), 2) + pow(points[i].back(), 2)));

        vector<vector<int>> result;
        int h, i, j;
        double key;
        vector<int> key2;
        for (h = points.size(); h > 0; h = h / 2) {
            for (i = h; i <= points.size() - 1; i++) {
                j = i;
                key = distance[j];
                key2 = points[j];
                while (j >= h && key < distance[j - h]) {
                    distance[j] = distance[j - h];
                    points[j] = points[j - h];
                    j = j - h;
                }
                distance[j] = key;
                points[j] = key2;
            }
        }

        for (int i = 0; i < k; i++)
            result.push_back(points[i]);

        return result;
    }
};