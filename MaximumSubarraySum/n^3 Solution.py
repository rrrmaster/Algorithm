if __name__ == '__main__':
    arr = [int(n) for n in input().split()]

    _max = 0
    n = len(arr)
    for a in range(n):
        for b in range(a,n):
            _max = max(_max, sum(arr[a:b+1]))
    print(_max)
