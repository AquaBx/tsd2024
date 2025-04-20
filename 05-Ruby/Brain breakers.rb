# 1

class Clock
  attr_reader :h
  attr_reader :m
  attr_reader :s

  def initialize(h,m,s)
    @h = h
    @m = m
    @s = s
    recalcule()
  end

  def recalcule()
    r = @s%60
    q = (@s-r)/60
    @s = r
    @m += q
    r = @m%60
    q = (@m-r)/60
    @m = r
    @h += q
  end
  
  def +(num)
    if !num.is_a?(Integer)
      raise "Not a integer"
    end
    @m += num
    recalcule()
    return self
  end

  def print
    puts "The current time is #{@h.to_s.rjust(2,"0")}:#{@m.to_s.rjust(2,"0")}:#{@s.to_s.rjust(2,"0")}!" 
  end

  def ==(cl)
    if !cl.is_a?(Clock)
      raise "Not a clock"
    end
    return cl.h == h && cl.m == @m && cl.s == @s
  end

  def self.measure_time
    time1 = Time.new
    yield
    time2 = Time.new

    puts "Time elapsed #{time2 - time1}"
  end
end

clock = Clock.new(10, 0, 0)
clock.print  # The current time is 10:00:00
clock += 30
clock.print  # The current time is 10:30:00
puts clock == Clock.new(10, 30, 0)  # true

# 2

Clock.measure_time do
  puts "Something is happening here"
  sleep 3
end
# Result: 3 seconds elapsed
