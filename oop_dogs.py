
class Dog:
    def __init__(self,name, age, friendliness):
        self.name = name
        self.age = age
        self.friendliness = friendliness
    def likes_walks(self):
        return True

class Samoyed(Dog):
    def __init__(self, name, age, friendliness):
        super().__init__(name, age, friendliness)

class Yorkie(Dog):
    def __init__(self, name, age, friendliness):
        super().__init__(name, age, friendliness)

class Mutt(Dog):
    def __init__(self, name, age, friendliness):
        super().__init__(name, age, friendliness)

class YorkieMutt (Yorkie, Mutt):
    def __init__(self, name, age, friendliness):
        super().__init__(name, age, friendliness)

coco = Mutt('Coco', 12, 10)
cocomillo = Mutt('Cocomillo', 10, 10)
print(cocomillo.name)