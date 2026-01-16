import sys
import random
from DataPacket import DataPacket
from DarkMatter import DarkMatter
from AntiMatter import AntiMatter
from ICritical import ICritical
from QuantumCollapseException import QuantumCollapseException

def main():
    # Storage list to hold all types of QuantumObjects (Polymorphism)
    storage_list = []

    while True:
        print("\n============================================")
        print("      QUANTUM STORAGE CONTROL PANEL (PY)")
        print("============================================")
        print("1. Add New Object (Random Generation)")
        print("2. List Inventory (Status Report)")
        print("3. Analyze Object (Decreases Stability)")
        print("4. Emergency Cooling (Critical Objects Only)")
        print("5. Shutdown System")
        
        choice = input("\nOperation Selection: ")

        if choice == "5":
            print("Shutting down system...")
            break

        # Route operations based on user input
        if choice == "1":
            add_new_object(storage_list)
        elif choice == "2":
            show_inventory(storage_list)
        elif choice == "3":
            analyze_object(storage_list)
        elif choice == "4":
            perform_cooling(storage_list)
        else:
            print("Error: Please enter a valid numeric command.")

def add_new_object(list_obj):
    # Randomly decide which type of object to create
    type_index = random.randint(0, 2)
    obj_id = input("Enter Object ID: ")
    if not obj_id.strip():
        print("ID cannot be empty.")
        return

    try:
        stability = int(input("Enter Initial Stability (1-99): "))
        danger = int(input("Enter Danger Level (1-10): "))
        
        # Instantiate the object; setters will validate stability and danger levels
        if type_index == 0:
            new_obj = DataPacket(obj_id, stability, danger)
        elif type_index == 1:
            new_obj = DarkMatter(obj_id, stability, danger)
        else:
            new_obj = AntiMatter(obj_id, stability, danger)

        # Successfully created objects are added to the list
        list_obj.append(new_obj)
        print(f"Success: {type(new_obj).__name__} added to storage.")
    
    except ValueError as e: 
        # Catch validation errors from setters or invalid numeric inputs
        print(f"Failure: {e}")

def show_inventory(list_obj):
    if not list_obj:
        print("\nStorage empty.")
    else:
        # Utilize the base class method to display object status
        for obj in list_obj:
            print(obj.get_status_info())

def analyze_object(list_obj):
    search_id = input("Enter ID to Analyze: ")
    # Find the object in the list using a generator expression
    obj = next((o for o in list_obj if o.object_id == search_id), None)

    if obj:
        try:
            print(f"Pre-Analysis Stability: {obj.stability}%")
            obj.analyze()
            print(f"Post-Analysis Stability: {obj.stability}%")
        except QuantumCollapseException as ex:
            # Handle the critical collapse event and terminate the system
            print(f"\n!!! CRITICAL SYSTEM COLLAPSE !!!\n{ex}")
            sys.exit(0)
    else:
        print("Object ID not found.")

def perform_cooling(list_obj):
    search_id = input("Enter ID for Cooling: ")
    obj = next((o for o in list_obj if o.object_id == search_id), None)

    if not obj:
        print("Object ID not found.")
    # Check if the object implements the ICritical interface behavior
    elif isinstance(obj, ICritical):
        obj.emergency_cooling()
    else:
        print("Denied: This object type is thermally stable and cannot be cooled.")

if __name__ == "__main__":
    main()