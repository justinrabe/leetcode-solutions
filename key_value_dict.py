class TimeMap:

    def __init__(self):
        self.kt_map ={}

    def set(self, key: str, value: str, timestamp: int) -> None:
        if not key in self.kt_map:
            self.kt_map[key] = {}
            
        self.kt_map[key][timestamp] = value
        
    def get(self, key: str, timestamp: int) -> str:
        if not key in self.kt_map:
            return ""
        for time in reversed(range(1, timestamp + 1)):
            if time in self.kt_map[key]:
                return self.kt_map[key][time]
        return ""