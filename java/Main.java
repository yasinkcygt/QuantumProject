import java.util.*;

public class Main {
    public static void main(String[] args) {
        // Using try-with-resources to ensure the Scanner is closed automatically
        try (Scanner scanner = new Scanner(System.in)) {
            List<QuantumObject> storageList = new ArrayList<>();
            Random random = new Random();

            while (true) {
                System.out.println("\n--- QUANTUM STORAGE CONTROL PANEL ---");
                System.out.println("1. Add New Object (Random Generation)");
                System.out.println("2. List Inventory");
                System.out.println("3. Analyze Object");
                System.out.println("4. Emergency Cooling");
                System.out.println("5. Shutdown System");
                System.out.print("Selection: ");

                String input = scanner.nextLine();
                int choice;
                try {
                    choice = Integer.parseInt(input);
                } catch (NumberFormatException e) {
                    System.out.println("Error: Please enter a valid numeric command.");
                    continue;
                }

                if (choice == 5) break;

                switch (choice) {
                    case 1 -> addObject(storageList, random, scanner);
                    case 2 -> showInventory(storageList);
                    case 3 -> analyzeObject(storageList, scanner);
                    case 4 -> performCooling(storageList, scanner);
                    default -> System.out.println("Unknown command.");
                }
            }
        } // The scanner is automatically closed here
    }

    private static void addObject(List<QuantumObject> list, Random random, Scanner sc) {
        int type = random.nextInt(3);
        System.out.print("Enter Object ID: ");
        String id = sc.nextLine();
        if (id.isEmpty()) return;

        try {
            System.out.print("Enter Stability (1-99): ");
            int st = Integer.parseInt(sc.nextLine());
            System.out.print("Enter Danger Level (1-10): ");
            int dl = Integer.parseInt(sc.nextLine());

            QuantumObject obj = switch (type) {
                case 0 -> new DataPacket(id, st, dl);
                case 1 -> new DarkMatter(id, st, dl);
                case 2 -> new AntiMatter(id, st, dl);
                default -> null;
            };

            if (obj != null && obj.getStability() > 0 && obj.getDangerLevel() >= 1) {
                list.add(obj);
                System.out.println("Object registered successfully.");
            } else {
                System.out.println("Failure: Invalid parameters.");
            }
        } catch (NumberFormatException e) {
            System.out.println("Error: Please enter valid numeric values for stability and danger.");
        }
    }

    private static void showInventory(List<QuantumObject> list) {
        if (list.isEmpty()) System.out.println("Storage is empty.");
        else list.forEach(o -> System.out.println(o.getStatusInfo()));
    }

    private static void analyzeObject(List<QuantumObject> list, Scanner sc) {
        System.out.print("Enter ID to analyze: ");
        String id = sc.nextLine();
        for (QuantumObject obj : list) {
            if (obj.getObjectID().equals(id)) {
                try {
                    System.out.println("Pre-Analysis Stability: " + obj.getStability() + "%");
                    obj.analyze();
                    System.out.println("Post-Analysis Stability: " + obj.getStability() + "%");
                } catch (QuantumCollapseException e) {
                    System.out.println("\n!!! SYSTEM COLLAPSE !!!\n" + e.getMessage());
                    System.exit(0);
                }
                return;
            }
        }
        System.out.println("Object not found.");
    }

    private static void performCooling(List<QuantumObject> list, Scanner sc) {
        System.out.print("Enter ID for cooling: ");
        String id = sc.nextLine();
        for (QuantumObject obj : list) {
            if (obj.getObjectID().equals(id)) {
                if (obj instanceof ICritical criticalObj) {
                    criticalObj.emergencyCooling();
                } else {
                    System.out.println("Object type is thermally stable and cannot be cooled.");
                }
                return;
            }
        }
        System.out.println("Object not found.");
    }
}