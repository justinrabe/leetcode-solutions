class Solution:
    def maxArea(self, height: List[int]) -> int:
        l = 0
        r = len(height) - 1
        m_area = 0
        while l < r:
            shorter = height[r] if height[r] < height[l] else height[l]
            area = shorter * (r - l)
            m_area = area if area > m_area else m_area
            if height[r] < height[l]: 
                r -= 1
            else:
                l += 1
                
        return m_area
        