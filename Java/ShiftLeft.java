public class ShiftLeft{
    public static void main(String[] args) {

        System.out.println("Java 시프트 연산자");

        int x = 0b00000010; //2

        System.out.println(
            String.format("%10s: %8s -> %2s", "          ", String.format(
                "%8s", Integer.toBinaryString(x)).replace(' ','0'), x));
        System.out.println(
            String.format("%10s: %8s -> %2s", "x = x << 1", String.format(
                "%8s", Integer.toBinaryString(x << 1)).replace(' ','0'), x << 1));
        System.out.println(
            String.format("%10s: %8s -> %2s", "x = x << 2", String.format(
                "%8s", Integer.toBinaryString(x << 2)).replace(' ','0'), x << 2));
        System.out.println(
            String.format("%10s: %8s -> %2s", "x = x << 3", String.format(
                "%8s", Integer.toBinaryString(x << 3)).replace(' ','0'), x << 3));


        x = 0b00010000;

        System.out.println(
            String.format("%10s: %8s -> %2s", "          ", String.format(
                "%8s", Integer.toBinaryString(x)).replace(' ','0'), x));
        System.out.println(
            String.format("%10s: %8s -> %2s", "x = x >> 1", String.format(
                "%8s", Integer.toBinaryString(x >> 1)).replace(' ','0'), x >> 1));
        System.out.println(
            String.format("%10s: %8s -> %2s", "x = x >> 2", String.format(
                "%8s", Integer.toBinaryString(x >> 2)).replace(' ','0'), x >> 2));
        System.out.println(
            String.format("%10s: %8s -> %2s", "x = x >> 3", String.format(
                "%8s", Integer.toBinaryString(x >> 3)).replace(' ','0'), x >> 3));
        
    }
}