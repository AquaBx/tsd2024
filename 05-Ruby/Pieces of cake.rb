# 1

def factorial( num )
    puts (1..num).inject { |mul, n| mul * n }
end

# factorial(6)  # 6!

# 2

class Integer
    def factorial
        if (self < 0)
            raise "Negative number"
        elsif (self == 0)
            puts 1
        else
            puts (1..self).inject { |mul, n| mul * n }
        end
    end
end

# 6.factorial
# 0.factorial
# -6.factorial

# 3

module InstanceModule
    def square
        puts self*self
    end
end

class Integer
    include InstanceModule
end

6.square

# 4

module ClassModule
    def sample(n)
        if (n < 1)
            raise "ArgumentError"
        end
        arr = []
        for i in 1..n do
            arr.push(rand(1000))
        end
        arr
    end

    alias random sample

end

class Integer 
    extend ClassModule
end


puts Integer.sample(3).inspect

# 5

puts Integer.random(3).inspect
