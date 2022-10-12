#list of dicts, username and age
users = [
{"username": "user1", "age":5},
{"username": "user2", "age":1},
{"username": "user3", "age":7},
{"username": "user4", "age":11},
{"username": "user5", "age":7},
{"username": "user6", "age":11}
]
ages = []
for u in users:
    ages.append(u["age"])

ages_comp = [u["age"] for u in users]

ages_sorted = ages.sort()
sorted(users, lambda u: u["age"])







