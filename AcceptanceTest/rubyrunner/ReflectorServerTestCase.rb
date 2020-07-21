require 'test/unit'
require 'thread'
require_relative 'FixParser'
require_relative 'ReflectorServer'

class ReflectorServerTestCase < Test::Unit::TestCase
  PORT = 5001

  def test_reflectMessages
    messages = "E8=FIX.4.2\0019=12\00135=A\001108=30\00110=31\001\n"
    messages += "R8=FIX.4.2\0019=12\00135=A\001108=10\00110=31\001\n"
    messages += "E8=FIX.4.2\0019=12\00135=A\001108=25\00110=31\001\n"
    messages += "R8=FIX.4.2\0019=12\00135=A\001108=15\00110=31\001\n"

    server = ReflectorServer.new(messages)
    Thread.start do
      server.listen(PORT)
    end
    server.wait

    s = TCPSocket.open("localhost", PORT)
    parser = FixParser.new(s)

    begin
      s.write("8=FIX.4.2\0019=12\00135=A\001108=30\00110=31\001")
      assert_equal("8=FIX.4.2\0019=12\00135=A\001108=10\00110=31\001", parser.readFixMessage)
      s.write("8=FIX.4.2\0019=12\00135=A\001108=30\00125=31\001")
      assert_equal("8=FIX.4.2\0019=12\00135=A\001108=15\00110=31\001", parser.readFixMessage)
    rescue IOError
    end
    
    s.close
    server.stop
  end
end
