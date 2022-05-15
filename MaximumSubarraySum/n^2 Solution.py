import time


def solution(array):
    value = 0
    n = len(arr)
    for a in range(n):
        _sum = 0
        for b in range(n):
            _sum += arr[b]
            value = max(value, _sum)
    return value


if __name__ == '__main__':
    arr = [int(n) for n in input().split()]

    start = time.time()

    _max = solution(arr)
    print("maximum subarray sum :", _max)
    print("time :", time.time() - start)
